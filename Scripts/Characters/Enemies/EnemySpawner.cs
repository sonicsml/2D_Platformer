public class EnemySpawner : Spawner<Enemy>
{
    public void DestroyEnemy()
    {
        gameObject.SetActive(false);
    }
}
