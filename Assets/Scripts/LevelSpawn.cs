using UnityEngine;

public class LevelSpawn : MonoBehaviour
{
    public GameObject Template;
    public GameObject TemplateEmpty;
    public GameObject SpawnTo;
    private float DistanceTravelled = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject Spawned = Instantiate(Template, SpawnTo.transform.position, Quaternion.identity, transform);
        SpawnTo.transform.position += new Vector3(0, 0, -199.4f);
        GameObject Spawned1 = Instantiate(Template, SpawnTo.transform.position, Quaternion.identity, transform);
        SpawnTo.transform.position += new Vector3(0, 0, -199.4f);
        GameObject Spawned2 = Instantiate(Template, SpawnTo.transform.position, Quaternion.identity, transform);
        SpawnTo.transform.position += new Vector3(0, 0, -199.4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, 50 * Time.deltaTime);

        if (transform.position.z - DistanceTravelled >= 199.3f)
        {
            DistanceTravelled = transform.position.z;
            GameObject Spawned = Instantiate(Template, SpawnTo.transform.position, Quaternion.identity, transform);
        }
    }
}
