using System;
using System.IO.Compression;
using System.Threading;

public class Archiv
{
	public Archiv()
	{

    }

    public void Archive(string startPath, string zipPath)
    {
        ZipFile.CreateFromDirectory(startPath, zipPath); 
    }

    public void Extract(string zipPath, string extractPath)
    {
        ZipFile.ExtractToDirectory(zipPath, extractPath);
    }
}
