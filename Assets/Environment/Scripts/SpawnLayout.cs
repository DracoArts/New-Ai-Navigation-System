using UnityEngine;

public class SpawnLayout : MonoBehaviour
{
    public GameObject[] Layouts;
    [Range(0, 1f)]
    public int LayoutChoice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
		Instantiate(Layouts[LayoutChoice], Vector3.zero, Quaternion.identity);
	}   
}
