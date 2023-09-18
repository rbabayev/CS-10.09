using System;

public class Storage
{
    public string MediaName { get; set; }
    public string Model { get; set; }

    public Storage(string mediaName, string model)
    {
        MediaName = mediaName;
        Model = model;
    }
}

public class DVD : Storage
{
    public double MediaSize { get; set; }
    public double TransferSpeed { get; set; }

    public DVD(string mediaName, string model, double mediaSize, double transferSpeed) : base(mediaName, model)
    {
        MediaSize = mediaSize;
        TransferSpeed = transferSpeed;
    }

    public void Copy(double fileSize)
    {
        double timeInSeconds = fileSize / (TransferSpeed * 1024);
        TimeSpan timeSpan = TimeSpan.FromSeconds(timeInSeconds);

        Console.WriteLine($"Copying {fileSize} MB of data to DVD: {MediaName}");
        Console.WriteLine($"Estimated time: {timeSpan.Hours} hours, {timeSpan.Minutes} minutes, {timeSpan.Seconds} seconds");
    }

    public void FreeMemory()
    {
        Console.WriteLine($"Freeing memory on DVD: {MediaName}");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"DVD Info - Name: {MediaName}, Model: {Model}, Size: {MediaSize} GB, Transfer Speed: {TransferSpeed}x");
    }
}

public class FLASH : Storage
{
    public double MediaSize { get; set; }
    public double TransferSpeed { get; set; }

    public FLASH(string mediaName, string model, double mediaSize, double transferSpeed) : base(mediaName, model)
    {
        MediaSize = mediaSize;
        TransferSpeed = transferSpeed;
    }

    public void Copy(double fileSize)
    {
        double timeInSeconds = fileSize / (TransferSpeed * 1024);
        TimeSpan timeSpan = TimeSpan.FromSeconds(timeInSeconds);

        Console.WriteLine($"Copying {fileSize} MB of data to FLASH drive: {MediaName}");
        Console.WriteLine($"Estimated time: {timeSpan.Hours} hours, {timeSpan.Minutes} minutes, {timeSpan.Seconds} seconds");
    }

    public void FreeMemory()
    {
        Console.WriteLine($"Freeing memory on FLASH drive: {MediaName}");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"FLASH Drive Info - Name: {MediaName}, Model: {Model}, Size: {MediaSize} GB, Transfer Speed: {TransferSpeed}x");
    }
}

public class HDD : Storage
{
    public double MediaSize { get; set; }
    public double TransferSpeed { get; set; }

    public HDD(string mediaName, string model, double mediaSize, double transferSpeed) : base(mediaName, model)
    {
        MediaSize = mediaSize;
        TransferSpeed = transferSpeed;
    }

    public void Copy(double fileSize)
    {
        double timeInSeconds = fileSize / (TransferSpeed * 1024);
        TimeSpan timeSpan = TimeSpan.FromSeconds(timeInSeconds);

        Console.WriteLine($"Copying {fileSize} MB of data to HDD: {MediaName}");
        Console.WriteLine($"Estimated time: {timeSpan.Hours} hours, {timeSpan.Minutes} minutes, {timeSpan.Seconds} seconds");
    }

    public void FreeMemory()
    {
        Console.WriteLine($"Freeing memory on HDD: {MediaName}");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"HDD Info - Name: {MediaName}, Model: {Model}, Size: {MediaSize} GB, Transfer Speed: {TransferSpeed}x");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        double fileSize = 565 * 1024; 

        DVD dvd = new DVD("DVD Disk", "DVD Model", 4.7, 1);
        FLASH flash = new FLASH("Flash Drive", "Flash Model", 128, 3);
        HDD hdd = new HDD("Hard Disk", "HDD Model", 2000, 0.48);

        dvd.Copy(fileSize);
        flash.Copy(fileSize);
        hdd.Copy(fileSize);
        Console.WriteLine("--------------------------------------------------------------");

        dvd.FreeMemory();
        flash.FreeMemory();
        hdd.FreeMemory();
        Console.WriteLine("--------------------------------------------------------------");

        dvd.PrintInfo();
        flash.PrintInfo();
        hdd.PrintInfo();
    }
}