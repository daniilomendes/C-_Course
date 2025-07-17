using System.Globalization;

namespace DateGuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // INICIANDO COM DATAS
            // var data = new DateTime();
            // var data = DateTime.Now;

            // Console.WriteLine(data);
            // -------------------------------------------------------------------------------------------------

            // OBTENDO VALORES DA DATA
            // var data = new DateTime(2025, 07, 17, 15, 43, 14);

            // Console.WriteLine(data);
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);
            // Console.WriteLine(data.DayOfWeek);
            // Console.WriteLine((int)data.DayOfWeek);
            // Console.WriteLine(data.DayOfYear);
            // -------------------------------------------------------------------------------------------------

            // FORMATANDO DATAS
            // var data = DateTime.Now;

            // Console.WriteLine(String.Format("{0:yyyy}", data));
            // Console.WriteLine(String.Format("{0:yy}", data));
            // Console.WriteLine(String.Format("{0:y}", data));
            // Console.WriteLine(String.Format("{0:MM}", data));
            // Console.WriteLine(String.Format("{0:M}", data));

            // Console.WriteLine(String.Format("{0:yyyy-MM-dd}", data));
            // Console.WriteLine(String.Format("{0:yyyy/MM/dd}", data));
            // Console.WriteLine(String.Format("{0:dd/MM/yyyy}", data));
            // Console.WriteLine(String.Format("{0:dd/MM/yyyy hh:mm:ss}", data));
            // -------------------------------------------------------------------------------------------------

            // PADRÕES DE FORMATAÇãO
            // var data = DateTime.Now;

            // Console.WriteLine(String.Format("{0:t}", data));
            // Console.WriteLine(String.Format("{0:d}", data));
            // Console.WriteLine(String.Format("{0:T}", data));
            // Console.WriteLine(String.Format("{0:D}", data));
            // Console.WriteLine(String.Format("{0:f}", data));
            // Console.WriteLine(String.Format("{0:g}", data));
            // Console.WriteLine(String.Format("{0:r}", data));
            // Console.WriteLine(String.Format("{0:R}", data));
            // Console.WriteLine(String.Format("{0:s}", data));
            // Console.WriteLine(String.Format("{0:u}", data));
            // -------------------------------------------------------------------------------------------------

            // ADICONANDO VALORES
            // var data = DateTime.Now;

            // Console.WriteLine(data.AddDays(15));
            // Console.WriteLine(data.AddMonths(1));
            // Console.WriteLine(data.AddYears(1));
            // Console.WriteLine(data.AddMinutes(30));
            // Console.WriteLine(data.AddHours(30));
            // -------------------------------------------------------------------------------------------------

            // COMPARANDO VALORES
            // DateTime? data = null;
            // var data = DateTime.Now;

            // Da erro por conta dos segundos
            // if (data == DateTime.Now)
            // {
            //     Console.WriteLine("É igual");
            // }
            // Mnaiera correta
            // if (data.Date == DateTime.Now.Date)
            // {
            //     Console.WriteLine("É igual");
            // }
            // -------------------------------------------------------------------------------------------------

            // CULTUREINFO
            // var ptPt = new CultureInfo("pt-PT");
            // var ptBr = new CultureInfo("pt-BR");
            // var en = new CultureInfo("en-US");
            // var de = new CultureInfo("de-DE");
            // var current = CultureInfo.CurrentCulture;

            // Console.WriteLine(string.Format("{0:D}", DateTime.Now));
            // Console.WriteLine(DateTime.Now.ToString("D", ptPt));
            // Console.WriteLine(DateTime.Now.ToString("D", ptBr));
            // Console.WriteLine(DateTime.Now.ToString("D", en));
            // Console.WriteLine(DateTime.Now.ToString("D", de));
            // Console.WriteLine(DateTime.Now.ToString("D", current));
            // -------------------------------------------------------------------------------------------------

            // TIMEZONE
            // var utcTime = DateTime.UtcNow;

            // Console.WriteLine(utcTime);
            // Console.WriteLine(DateTime.Now);
            // Console.WriteLine(utcTime.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.WriteLine(timezoneAustralia);

            // var hourAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcTime, timezoneAustralia);
            // Console.WriteLine(hourAustralia);

            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcTime, timezone));
            //     Console.WriteLine("---------------------------------------------------------");
            // }
            // -------------------------------------------------------------------------------------------------

            // TIMESPAN
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMInutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMInutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMInutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

            Console.WriteLine(DateTime.DaysInMonth(2025, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
            // -------------------------------------------------------------------------------------------------
        }
        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}