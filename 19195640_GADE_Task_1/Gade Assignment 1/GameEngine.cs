using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gade_Assignment_1
{
    class GameEngine
    {
        public GameEngine()
        {
            map = new Map();
            map.UnitGeneration();
        }
        public Map map;

        public int roundscompleted=0;

        public void startround()
        {
            //combat for ranged units
            foreach (RangedUnit R in map.rangedUnits)
            {
                Unit enemy = checkforenemies(R);
                if (enemy != null)
                {
                    if (R.Health >= 25 / 100 * R.MaxHealth)
                    {
                        //movecloser
                        R.Move(Movecloser());
                        if (enemy is RangedUnit)
                        {
                            R.Move(RunAway());//won't attack team mate
                        }
                        else
                        {
                            MeleeUnit Enemy = enemy as MeleeUnit;
                            if (R.Can_AttackM(Enemy))
                            {
                                R.CombatM(Enemy);
                            }
                        }
                       
                    }
                    else
                    {
                        R.Move(RunAway());
                        //run away 
                    }
                }
                else
                {
                    //do nothing
                }
            }
            //combat for melee units
            foreach (MeleeUnit M in map.meleeUnits)
            {
                Unit enemy = checkforenemies(M);
                if (enemy != null)
                {
                    if (M.Health >= 25 / 100 * M.MaxHealth)
                    {
                        //movecloser
                        M.Move(Movecloser());
                        if (enemy is RangedUnit)
                        {
                            RangedUnit Enemy = enemy as RangedUnit;
                            if (M.Can_AttackR(Enemy))
                            {
                                M.CombatR(Enemy);
                            }
                        }
                        else
                        {
                            M.Move(RunAway());//won't attack team mate
                        }
                        
                    }
                    else
                    {
                        M.Move(RunAway());

                        //run away 
                    }
                }
                else
                {
                    //do nothing
                }
            }
         roundscompleted++;
        }
        public void MapUpdate()
        {


        }
        public string Updateunit()
        {
            string info =
                map.get_melee_unit_info()
                + map.get_ranged_unit_info();
            return info;

        }
       
        public string Updatedisplay()
        {
            return map.DisplayMap();
        }
        public Unit checkforenemies(Unit lookingforenemies)
        {
            if (lookingforenemies is RangedUnit)
            {
                RangedUnit enemy = lookingforenemies as RangedUnit;
                enemy = lookingforenemies.Closest_Other_EnemyR(map.rangedUnits);
                return enemy;
            }
            else if (lookingforenemies is MeleeUnit)
            {
                MeleeUnit enemy = lookingforenemies as MeleeUnit;
                enemy = lookingforenemies.Closest_Other_EnemyM(map.meleeUnits);
                return enemy;
            }           
            else
            {
                return null;
            }

        }
        public Map.Direction RunAway()
        {
            return Map.Direction.North;
        }
        public Map.Direction Movecloser()
        {
            return Map.Direction.West;
        }

    }
}
