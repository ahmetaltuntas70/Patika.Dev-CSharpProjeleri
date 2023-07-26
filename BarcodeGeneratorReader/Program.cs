

using BarcodeLib;
using BarcodeStandard;
using BarcodeGeneratorReader;
using System.Diagnostics;

Barcode barcode = BarcodeGeneratorReader.Process.CreateAndSaveBarcode("777");
Console.WriteLine(BarcodeGeneratorReader.Process.ReadBarcode(barcode));

barcode = BarcodeGeneratorReader.Process.CreateAndSaveBarcode("11");
Console.WriteLine(BarcodeGeneratorReader.Process.ReadBarcode(barcode));

barcode = BarcodeGeneratorReader.Process.CreateAndSaveBarcode("111");
Console.WriteLine(BarcodeGeneratorReader.Process.ReadBarcode(barcode));

barcode = BarcodeGeneratorReader.Process.CreateAndSaveBarcode("1111");
Console.WriteLine(BarcodeGeneratorReader.Process.ReadBarcode(barcode));
