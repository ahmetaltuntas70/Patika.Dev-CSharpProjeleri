using BarcodeLib;
using BarcodeStandard;
using System;
using System.Text.Json;

namespace BarcodeGeneratorReader
{
    class Process
    {
        static TYPE type = TYPE.PHARMACODE;
        public static Barcode CreateAndSaveBarcode(string data)
        {
            Barcode barcode = new Barcode(data, type);
            barcode.Encode(type, data);
            barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barkod oluşturuldu ve kaydedildi, saklanan data -> {0}", data);
            return barcode;
        }
        public static string ReadBarcode(Barcode barcode)
        {
            return "Barkod değeri = " + barcode.RawData + " \n";
        }
    }
}
