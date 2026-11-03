using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whizzys_Potion_Shop
{
    public class GameTime
    {
        public int CurrentDay { get; private set; }
        public string FormattedDay => $"Day {CurrentDay}";
        public const int OpeningTime = 9 * 60;
        public const int ClosingTime = 17 * 60;

        // Time spent on each action in minutes
        public const int AcceptOrderMinutes = 1;
        public const int BrewSessionMinutes = 60;
        public const int CollectPotionMinutes = 2;
        public const int ServeOrderMinutes = 2;
        public const int CustomerLeaveMinutes = 1;
        public const int RefuseOrderMinutes = 5;

        public int CurrentMinutes { get; private set; }

        public bool IsClosingTime => CurrentMinutes >= ClosingTime;

        public string FormattedTime
        {
            get
            {
                return DateTime.Today
                    .AddMinutes(CurrentMinutes)
                    .ToString("h:mm tt");
            }
        }

        public GameTime()
        {
            CurrentDay = 1;
            ResetDay();
        }

        public void NextDay()
        {
            CurrentDay++;
            ResetDay();
        }

        public void AdvanceTime(int minutes)
        {
            if (minutes < 0)
                return;

            CurrentMinutes += minutes;

            if (CurrentMinutes > ClosingTime)
                CurrentMinutes = ClosingTime;
        }

        public void ResetDay()
        {
            CurrentMinutes = OpeningTime;
        }
    }
}

