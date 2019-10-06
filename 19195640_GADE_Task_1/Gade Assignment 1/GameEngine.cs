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

        public int RoundsCompleted=0;

        public void MapUpdate()
        {


        }

        public void Updateunit()
        {


        }
        public string Updatedisplay()
        {
            return map.DisplayMap();
        }

        public void startround()
        {
            foreach (RangedUnit R in map.rangedUnits)
            {
                Unit enemy = checkforenemies(R);
                if (enemy != null)
                {
                    if (R.Health >= 25/100*R.MaxHealth)
                    {
                        //movecloser
                        R.Move(Movecloser());
                        if (enemy is RangedUnit)
                        {
                            RangedUnit Enemy = enemy as RangedUnit;
                            if (R.Can_AttackR(Enemy))
                            {
                                R.CombatR(Enemy);
                            }
                        }
                        if (enemy is MeleeUnit)
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


            foreach (MeleeUnit R in map.meleeUnits)
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
                            RangedUnit Enemy = enemy as RangedUnit;
                            if (R.Can_AttackR(Enemy))
                            {
                                R.CombatR(Enemy);
                            }
                        }
                        if (enemy is MeleeUnit)
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
            RoundsCompleted++;
        }

        public Unit checkforenemies(Unit lookingforenemies)
        {
            Unit enemy = lookingforenemies.Closest_Other_Enemy();
            return enemy;
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
