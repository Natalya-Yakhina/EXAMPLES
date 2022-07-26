// Как посмотреть содержимое папки

void CatalogInfo(string path, string indent = " ")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalog.length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

FileInfo[] files = CatalogInfo.GetFiles();

    for (int i = 0; i < files.length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"C:\Users\Яхина Н А\Desktop\Examples\Examples-1\Examples\Example001_HelloWorld";
CatalogInfo(path);