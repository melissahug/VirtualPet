using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class PetAction
    {
        //field
        public int feedPet;
        public int waterForPet;
        public int giftForPet;

        //properties
        public int FeedPet
        {
            get { return this.feedPet; }
            set { this.feedPet = value; }
        }

        public int WaterForPet
        {
            get { return this.waterForPet; }
            set { this.waterForPet = value; }
        }

        public int GiftForPet
        {
            get { return this.giftForPet; }
            set { this.giftForPet = value; }
        }
        

        //method
        

        public int GiveFood()
                   
            {
                return (this.feedPet + 5);
            }

        public int GiveWater()
            {
            return (waterForPet - 4);
            }

        public int GiveGift()
            {
            return (giftForPet +10);
            }
      }
}
   
