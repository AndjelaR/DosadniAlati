using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;
using System.Linq;

namespace DosadniAlati
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]

    public class Class1 : IExternalCommand
    {

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiap = commandData.Application;
            UIDocument uidoc = uiap.ActiveUIDocument;
            Application app = uiap.Application;
            Document doc = uidoc.Document;

            Komande komande = new Komande();
            komande.ShowDialog();

            int tipKomande = komande.komand;

            switch (tipKomande)
            {
                case 1:
                    komande.Dispose();
                    DodjelaBrojaSobe dodjelaBroja = new DodjelaBrojaSobe();
                    dodjelaBroja.ShowDialog();
                    Boolean auto = dodjelaBroja.auto;
                    Boolean unos = dodjelaBroja.unos;

                    int brojSobe = dodjelaBroja.brojSobe;
                    if (unos == true)
                    {
                        DodjelaBrojaSoba(doc, brojSobe);
                        //  komande.ShowDialog() ;


                    }
                    else if (auto == true)
                    {
                        DodjelaBrojaSoba(doc, 100);

                    }
                    break;

                case 2:
                    PregledNamjestaja(doc, uidoc);

                    break;
                case 3:
                    komande.Close();
                    IspisParametara(doc, commandData, uidoc);
                    break;

                default:
                    break;
            }
            return Autodesk.Revit.UI.Result.Succeeded;

        }
        private void DodjelaBrojaSoba(Document doc, int pocetniBrojSobe)
        {
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Rooms);
            FilteredElementCollector kolektor = new FilteredElementCollector(doc);
            IList<Element> rooms = kolektor.WherePasses(filter).WhereElementIsNotElementType().ToElements();
            List<Room> sobe = new List<Room>();
            int brojSoba = sobe.Count;

            FilteredElementCollector kol = new FilteredElementCollector(doc);
            IList<Element> leveli = kol.WherePasses(new ElementCategoryFilter(BuiltInCategory.OST_Levels)).WhereElementIsNotElementType().ToElements();
            int brojLevela = leveli.Count;

            foreach (Room e in rooms)
            {
                sobe.Add(e);
            }
            string prikaz = "Pregled soba: \n";

            int level = 1;


            using (Transaction tr = new Transaction(doc))
            {
                tr.Start("Transaction");
                for (int j = 0; j < brojLevela; j++)
                {
                    foreach (Room room in sobe)
                    {
                        if (room.Level.Name == "Level " + level.ToString())
                        {
                            room.Number = pocetniBrojSobe.ToString();
                            prikaz += room.Name + " - Level " + room.Level.Name + "\n";
                            pocetniBrojSobe++;
                        }

                    }
                    level++;
                }

                tr.Commit();
            }
            TaskDialog.Show("Sobe", prikaz);
        }

        private void PregledNamjestaja(Document doc, UIDocument uidoc)
        {
            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Furniture);
            FilteredElementCollector kolektor = new FilteredElementCollector(doc);
            IList<Element> furnitureList = kolektor.WherePasses(filter).WhereElementIsNotElementType().ToElements();

            View active = doc.ActiveView;
            Parameter level = active.LookupParameter("Associated Level");
            string levelName = level.AsString();

            string namjestaj = "";
            foreach (Element el in furnitureList)
            {
                Level lvl = el.Document.GetElement(el.LevelId) as Level;
                if (lvl.Name == levelName)
                {
                    namjestaj += el.Name + " \n";
                }
            }
            TaskDialog.Show("Ispis", namjestaj);

        }

        private void IspisParametara(Document doc, ExternalCommandData commandData, UIDocument uidoc)
        {
            string prikaz = "Parametri selektovanih elemenata: \n";
            List<string> listaImena;

            List<string> listaVrijednosti;
            Selection selekcija = commandData.Application.ActiveUIDocument.Selection;
            ICollection<ElementId> idSelekcije = uidoc.Selection.GetElementIds();

            int i = 1;
            foreach (ElementId id in idSelekcije)
            {
                Element element = doc.GetElement(id);

                int brojParametara = element.Parameters.Size;
                listaImena = new List<string>();
                listaVrijednosti = new List<string>();

                int k = 0;
                foreach (Parameter parameter in element.Parameters)
                {
                    listaImena.Insert(k, parameter.Definition.Name.ToString());
                    switch (parameter.StorageType)
                    {
                        case StorageType.Double:
                            listaVrijednosti.Insert(k, parameter.AsValueString());
                            break;
                        case StorageType.ElementId:
                            Autodesk.Revit.DB.ElementId ID = parameter.AsElementId();
                            if (ID.IntegerValue >= 0)
                            {
                                listaVrijednosti.Insert(k, doc.GetElement(ID).Name);
                            }
                            else
                            {
                                listaVrijednosti.Insert(k, ID.IntegerValue.ToString());
                            }
                            break;
                        case StorageType.Integer:
                            if (ParameterType.YesNo == parameter.Definition.ParameterType)
                            {
                                if (parameter.AsInteger() == 0)
                                {
                                    listaVrijednosti.Insert(k, "False");
                                }
                                else
                                {
                                    listaVrijednosti.Insert(k, "True");
                                }
                            }
                            else
                            {
                                listaVrijednosti.Insert(k, parameter.AsInteger().ToString());
                            }
                            break;
                        case StorageType.String:
                            listaVrijednosti.Insert(k, parameter.AsString());
                            break;
                        default:
                            listaVrijednosti.Insert(k, "Unexposed parameter.");
                            break;
                    }


                    k++;
                }
                i++;

                PrikazParametara prikazParametara = new PrikazParametara(brojParametara, listaImena, listaVrijednosti);
                prikazParametara.ShowDialog();

                using (Transaction tr = new Transaction(doc))
                {
                    tr.Start("Transaction");
                    foreach (ElementId id_ in idSelekcije)
                    {
                        Element el = doc.GetElement(id_);

                        foreach (Parameter p in element.Parameters)
                        {
                            if (p.Definition.Name == prikazParametara.nazivPromijenjenogParametra)
                            {
                                p.SetValueString(prikazParametara.promjena);
                            }
                        }


                    }
                    tr.Commit();
                }

            }
        }
    }
}
