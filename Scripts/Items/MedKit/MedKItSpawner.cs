public class MedKItSpawner : Spawner<MedKit> 
{
    protected override void OnSpawn(MedKit medKit)
    {
        medKit.OnCollectedMedkit += DestroyMedkit;
    }

    private void DestroyMedkit(MedKit medKit)
    {
        medKit.OnCollectedMedkit -= DestroyMedkit;
        medKit.gameObject.SetActive(false);
    }
}
