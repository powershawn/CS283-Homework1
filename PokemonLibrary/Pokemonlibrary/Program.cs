using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonlibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon aspok = new Pokemon()
            {
                Name = "妙蛙種子",
                Sex = "男",
                MaxHP = "100",
                NowHP = "66",

                Weight = "77kg",
                Type = "草系",
                Power = "66666",
                PowerCandy = "123",
                PowerUp = "4444",
                PowerUpCandy = "55",
                Evolve = "111",
                Skill1 = "藤鞭",
                Skill2 = "汙泥炸彈",
                Skill1Deplete ="7",
                Skill2Deplete = "80"

            };
            Console.WriteLine("神奇寶貝名字:{0},性別:{1},最大血量:{2},現在血量:{3},重量:{4},屬性:{5},星星數:{6},糖果數:{7},升級需要的星星數:{8},升級需要的糖果數:{9},進化需要的星星數數:{10},技能1:{11},技能2:{12},技能消耗1:{13},技能消耗2:{14}"
                , aspok.Name
                , aspok.Sex
                , aspok.MaxHP
                , aspok.NowHP
                , aspok.Weight
                , aspok.Type
                , aspok.Power
                , aspok.PowerCandy
                , aspok.PowerUp
                , aspok.PowerUpCandy
                , aspok.Evolve
                , aspok.Skill1
                , aspok.Skill2
                , aspok.Skill1Deplete
                , aspok.Skill2Deplete

            );
        }
    }
}
