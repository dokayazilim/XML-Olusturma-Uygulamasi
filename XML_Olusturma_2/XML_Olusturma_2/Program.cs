using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Olusturma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xml oluşturma...>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            /*List<Ogrenci> Ogrencilerim = new List<Ogrenci>();
            for (int i = 0; i < 100; i++) 
            {
                Ogrenci Temp = new Ogrenci();
                Temp.ID = Guid.NewGuid();
                Temp.Isim = FakeData.NameData.GetFirstName();
                Temp.soyisim = FakeData.NameData.GetSurname();
                Temp.Numara = FakeData.NumberData.GetNumber(100,500);
                Ogrencilerim.Add(Temp);
            }*/

            /*XDocument Doc = new XDocument(new XDeclaration("1.1","UTF-8","yes"),new XElement("Ogrencilerim",Ogrencilerim.Select(I=>new XElement("Ogrenci",new XElement("ID",I.ID),new XElement("Isim",I.Isim),new XElement("Soyisim",I.soyisim),new XElement("Numara",I.Numara)))));
            Doc.Save(@"C:\Users\basal\OneDrive\Desktop\c# dersler\XML_Olusturma_2\Ogrenci\Ogrencilerim.xml");*/
            
            
            //xml dosya okuma...>>>>>>
            List<Ogrenci> OkunanData = new List<Ogrenci>();
            XDocument DocOku = XDocument.Load(@"C:\Users\basal\OneDrive\Desktop\c# dersler\XML_Olusturma_2\Ogrenci\Ogrencilerim.xml");
            List<XElement> OkunanXElement = DocOku.Descendants("Ogrenci").ToList();

            foreach (XElement item in OkunanXElement)
            {
                Ogrenci Temp = new Ogrenci();
                Temp.ID = Guid.Parse (item.Element("ID").Value);
                Temp.Isim = item.Element("Isim").Value;
                Temp.soyisim = item.Element("Soyisim").Value;
                Temp.Numara = int.Parse(item.Element("Numara").Value);
                OkunanData.Add(Temp);
            }
            Console.ReadLine();


        }
    }
}
