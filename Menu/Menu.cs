using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<object> AvailableMenuItems
        {
            get 
            {
                List<object> menu = new List<object>();
                menu.AddRange(AvailableEntrees);
                menu.AddRange(AvailableSides);
                menu.AddRange(AvailableDrinks);
                menu.AddRange(AvailableCombos);
                return menu;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object ob in AvailableMenuItems)
            {
                sb.Append(ob.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public List<object> AvailableEntrees
        {
            get
            {
                List<object> entrees = new List<object>();
                Brontowurst bw = new Brontowurst();
                DinoNuggets dn = new DinoNuggets();
                PrehistoricPBJ pb = new PrehistoricPBJ();
                PterodactylWings pw = new PterodactylWings();
                SteakosaurusBurger sb = new SteakosaurusBurger();
                TRexKingBurger rexKingBurger = new TRexKingBurger();
                VelociWrap vw = new VelociWrap();
                entrees.Add(bw);
                entrees.Add(dn);
                entrees.Add(pb);
                entrees.Add(pw);
                entrees.Add(sb);
                entrees.Add(rexKingBurger);
                entrees.Add(vw);
                return entrees;
            }
        }

        public List<object> AvailableSides
        {
            get
            {
                List<object> sides = new List<object>();
                Fryceritops fr = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks ms = new MezzorellaSticks();
                Triceritots tt = new Triceritots();
                sides.Add(fr);
                sides.Add(mac);
                sides.Add(ms);
                sides.Add(tt);
                return sides;
            }
        }

        public List<object> AvailableDrinks
        {
            get
            {
                List<object> drinks = new List<object>();
                JurrasicJava jj = new JurrasicJava();
                Sodasaurus ss = new Sodasaurus();
                Tyrannotea tt = new Tyrannotea();
                Water w = new Water();
                drinks.Add(jj);
                drinks.Add(ss);
                drinks.Add(tt);
                drinks.Add(w);
                return drinks;
            }
        }

        public List<object> AvailableCombos
        {
            get
            {
                List<object> combos = new List<object>();
                Brontowurst bw = new Brontowurst();
                DinoNuggets dn = new DinoNuggets();
                PrehistoricPBJ pb = new PrehistoricPBJ();
                PterodactylWings pw = new PterodactylWings();
                SteakosaurusBurger sb = new SteakosaurusBurger();
                TRexKingBurger rexKingBurger = new TRexKingBurger();
                VelociWrap vw = new VelociWrap();
                CretaceousCombo cone = new CretaceousCombo(bw);
                CretaceousCombo ctwo = new CretaceousCombo(dn);
                CretaceousCombo cthree = new CretaceousCombo(pb);
                CretaceousCombo cfour = new CretaceousCombo(pw);
                CretaceousCombo cfive = new CretaceousCombo(sb);
                CretaceousCombo csix = new CretaceousCombo(rexKingBurger);
                CretaceousCombo cseven = new CretaceousCombo(vw);
                combos.Add(cone);
                combos.Add(ctwo);
                combos.Add(cthree);
                combos.Add(cfour);
                combos.Add(cfive);
                combos.Add(csix);
                combos.Add(cseven);
                return combos;
            }
        }

        
    }
}
