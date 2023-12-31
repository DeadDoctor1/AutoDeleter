using System.IO;

AutoSafeDeleter StandartPath = new AutoSafeDeleter();
string[] file_extention = {".log"};
StandartPath.FindFiles(StandartPath.path, file_extention);
Console.WriteLine(StandartPath.path);
Console.WriteLine($"Find Files: {StandartPath.count}\nSize Files: {StandartPath.size} Mb\nEmpty Folder: {StandartPath.emptyFolder}");

//StandartPath.DeleteEmptyFolder(StandartPath.listEmptyFolder);
//StandartPath.DeleteFile(StandartPath.listFiles);

Console.WriteLine("//////////////////////////////////////////////////////////////////");

AutoSafeDeleter Custom = new AutoSafeDeleter();
string[] ext = { ".fbx",".spp",".blend"};
Custom.path = @"D:\Graphics\Works";
Custom.FindFiles(Custom.path, ext);
Console.WriteLine(Custom.path);
Console.WriteLine($"Find Files: {Custom.count}\nSize Files: {Custom.size} Mb\nEmpty Folder: {Custom.emptyFolder}");

class AutoSafeDeleter 
{
    public int count = 0;
    public int size = 0;
    public int emptyFolder = 0;
    public List<string> listFiles = new List<string>();
    public List<string> listEmptyFolder = new List<string>();

    public string path = GetUserName();
        
    public void FindFiles(string path, string[] extentions) 
    {
        var directories = GetFileCollection(path);
        var files = SortFile(directories, extentions);
        var count_files = files.Count;
        var lenght_files = FileLenght(files);
        var empty_folder = FindEmptyFolder(path);
        var count_empty_folder = empty_folder.Count;

        count = count_files;
        size = lenght_files;
        emptyFolder = empty_folder.Count;
        listFiles = files;
        listEmptyFolder = empty_folder;
    }


    static string GetUserName()
    {
        string get_username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        string userName = get_username.Substring(get_username.LastIndexOf('\\'));
        var path = @"C:\Users" + userName + @"\AppData\Local\Temp";
        return path;
    }

    IEnumerable<string> GetFileCollection(string path)
    {
        var directories = Directory.EnumerateFiles(path, "", SearchOption.AllDirectories);
        return directories;
    }

    List<string> SortFile(IEnumerable<string> FileCollection, string[] Extentions)
    {
        // Создаю новый список для отсортированных файлов
        List<string> sortFilesPath = new List<string>();

        // Циклом foreach перебираю пути к файлaм с помощью фильтра и добавляю в список
        foreach (var filePath in FileCollection.Where(s => Extentions.Any(ext => ext == Path.GetExtension(s))))
        {
            sortFilesPath.Add(filePath);
        }
        return sortFilesPath;
    }

    int FileLenght(List<string> SortFileList)
    {
        // Создаю список для хранения размеров всех файлов
        List<long> sizeList = new List<long>();
        foreach (var length in SortFileList)
        {
            long lengthFile = new System.IO.FileInfo(length).Length;
            sizeList.Add(lengthFile);
        }
        var size = Convert.ToInt32((sizeList.Sum())/ 1048576);
        return size;
    }

    List<string> FindEmptyFolder(string Path)
    {
        // Список для путей пустых папок
        List<string> EmptyFolder_Path = new List<string>();

        // Получаем коллекцию путей к папкам
        var folderPaths = System.IO.Directory.EnumerateDirectories(Path, "", SearchOption.AllDirectories);
        // Перебор путей в коллекции
        foreach (var folderPath in folderPaths)
        {
            // Проверка, есть ли по путям файлы
            var isFullFolder = System.IO.Directory.GetFiles(folderPath, "", SearchOption.AllDirectories).Length;
            if (isFullFolder == 0)
            {
                EmptyFolder_Path.Add(folderPath);
            }
        }
        EmptyFolder_Path.Reverse();
        return EmptyFolder_Path;
    }

    public void DeleteFile(IEnumerable<string> FilePathCollection)
    {
        // Удаление перебором найденных файлов
        foreach (var delete_File in FilePathCollection)
        {
            FileInfo fileInf = new FileInfo(delete_File);
            fileInf.Delete();
        }
    }

    public void DeleteEmptyFolder(List<string> EmptyFolderList)
    {
        // Удаление перебором пустых папок
        foreach (var delete_Folder in EmptyFolderList)
        {
            Directory.Delete(delete_Folder);

        }
    }
}

