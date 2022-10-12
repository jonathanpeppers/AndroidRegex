#define FAST_REGEX

using System.Text.RegularExpressions;

namespace AndroidRegex
{
	[Activity(Label = "@string/app_name", MainLauncher = true)]
	public class MainActivity : Activity
	{
        private static readonly Regex s_myCoolRegex = new("abc|def", RegexOptions.Compiled | RegexOptions.IgnoreCase);

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
	}
}