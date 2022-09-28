using PDF_Splitter;

PDFSplitter pdf = new PDFSplitter();

string[] files = await pdf.FindDocuments();

foreach (var item in files)
{
    await pdf.Split("2;4;2;2;4", item);
}
