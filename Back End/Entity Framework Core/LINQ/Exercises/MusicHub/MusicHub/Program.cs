namespace MusicHub
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Globalization;
    using Microsoft.VisualBasic;
    using System.Numerics;
    using MusicHub.Data;

    public class StartUp
    {
        static void Main()
        {
            MusicHubDbContext context = new MusicHubDbContext();

            // 2
            Console.WriteLine(ExportAlbumsInfo(context, 9));
            // 3
            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {

            return "";
        }

        public string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            return "";
        }
    }
}