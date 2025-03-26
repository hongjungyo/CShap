using System.Linq.Expressions;
using UnityEngine;
namespace Override
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //플레이어 클래스 인스턴스
            Player player = new Player(100, 30);
            //몬스터 클래스 인스턴스
            Goblin go = new Goblin(50, 10);
            Skeleton sk = new Skeleton(100, 20);
            Zombie zb = new Zombie(200, 30);

            //전투
            player.TakeDamege(go);
            DrawHealth(player);
            player.TakeDamege(sk);
            DrawHealth(player);
            player.TakeDamege(zb);
            DrawHealth(player);

            go.TakeDamege(player);
            DrawHealth(go);
            go.TakeDamege(player);
            DrawHealth(sk);
            go.TakeDamege(player);
            DrawHealth(zb);


        }
        //캐릭터 health 그리기
        public void DrawHealth(Character ch)
        {
            Debug.Log($"{ch}: {ch.heath}");
        }
        /*
        public void DrawPlayerHealth(Player player)
        {
            Debug.Log($"{player}: {player.heath}");
        }
        public void DrawGoblinHealth(Goblin goblin )
        {
            Debug.Log($"{goblin}: {goblin.heath}");
        }
        public void DrawSkeletonHealth(Skeleton skeleton)
        {
            Debug.Log($"{skeleton}: {skeleton.heath}");
        }
        public void DrawZombieHealth(Zombie zombie)
        {
            Debug.Log($"{zombie}: {zombie.heath}");
        }
        */
    }
}