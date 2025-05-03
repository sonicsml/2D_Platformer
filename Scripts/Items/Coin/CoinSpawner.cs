public class CoinSpawner : Spawner<Coin> 
{
    protected override void OnSpawn(Coin coin)
    {
        coin.OnCollectedCoin += DestroyCoin;
    }

    private void DestroyCoin(Coin coin)
    {
        coin.OnCollectedCoin -= DestroyCoin;
        coin.gameObject.SetActive(false);
    }
}