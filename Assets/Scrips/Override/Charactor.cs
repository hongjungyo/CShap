using UnityEngine;
namespace Override
{
    //플레이어(....), 몬스터(슬라임, 좀비, 고블린, ...........)
    //모든 캐릭터의 부모클래스(캐릭터가 가지고 있는 공통기능)
    public abstract class Character
    {
        public abstract int GetTotalAttack();

        public int heath;
        public int baseATK;

        //생성자
        public Character(int hp, int atk)
        {
            this.heath = hp;
            this.baseATK = atk;
        }

        //매개변수로 나를 공격하는 캐릭터 개체를 전달해준다.
        public void TakeDamege(Character other)
        {
            heath -= other.GetTotalAttack();
        }
    }
    //플레이어
    public class Player : Character
    {
        public Player() : this(10, 20) { }
        public Player(int hp, int atk) : base(hp, atk) { }
        public override int GetTotalAttack()
        { 
            int total = 0;
            total += this.baseATK;
            //장비
            //스킬
            //상성

            return total;
        }
        
    }
    //몬스터: 슬라임, 좀비, 고블린, ...... 등의 부모 클래스
    public class Monster : Character
    {
        //생성자
        public Monster(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseATK;
            //장비
            //스킬
            //상성

            return total;
        }
    }
        //슬라임, 좀비, 고블린, ...... 공통 기능 구현
        //......

        //고블린
        public class Goblin : Monster
        {
            //
            public int posX, posY;

            //생성자
            public Goblin(int hp, int atk) : base(hp, atk) { }
            public Goblin() : this(10, 20) { }
            public override int GetTotalAttack()
            {
                int total = 0;
                total += this.baseATK;
                //장비
                //스킬
                //상성

                return total;
            }
            public void SetPosition(int x, int y)
            {
                this.posX = x;
                this.posY = y;
            }

        }

        //스켈레톤
        public class Skeleton : Monster
        {
            //생성자
            public Skeleton(int hp, int atk) : base(hp, atk) { }
           
            public override int GetTotalAttack()
            {
                int total = 0;
                total += this.baseATK;
                //스킬
                //상성

                return total;
            }
        }

        //좀비
        public class Zombie : Monster
        {
            //생성자
            public Zombie(int hp, int atk) : base(hp, atk) { }

            public override int GetTotalAttack()
            {
                int total = 0;
                total += this.baseATK;
                //스킬
                //상성

                return total;
            }
        }
}