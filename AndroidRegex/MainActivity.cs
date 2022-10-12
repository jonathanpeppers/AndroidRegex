//Uncomment to try the "fast" one
//#define FAST_REGEX

using System.Text.RegularExpressions;

namespace AndroidRegex
{
	[Activity(Label = "@string/app_name", MainLauncher = true)]
	public partial class MainActivity : Activity
	{
        private static readonly Regex s_myCoolRegex =
#if FAST_REGEX
            MyCoolRegex();
#else
			new("abc|def", RegexOptions.Compiled | RegexOptions.IgnoreCase);
#endif

        protected override void OnCreate(Bundle? savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			var text = ".NET is definitely cool!";
            if (s_myCoolRegex.IsMatch(text))
			{
				Console.WriteLine("Text matched!");
			}
			else
			{
                Console.WriteLine("No match!");
            }

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
		}

#if FAST_REGEX
        [GeneratedRegex("abc|def", RegexOptions.IgnoreCase | RegexOptions.Compiled, "en-US")]
		private static partial Regex MyCoolRegex();
#endif
	}
}