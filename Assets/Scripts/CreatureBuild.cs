using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureBuild : MonoBehaviour {
    public int NumberOfHeads = 0;
    public int NumberOfBodyParts = 0;
    public int NumberOfArms = 0;
    public int NumberOfLowerBody = 0;
    public int NumberOfLegs = 0;
    private ArrayList Nodes;
    GameObject Creature, CreatureParts;
	// Use this for initialization
	void Start ()
    {
        Creature = new GameObject("Creature");
        Nodes = new ArrayList();
        CreateLowerBody();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void CreateHead()
    {

    }

    void CreateBody()
    {

    }

    void CreateArms()
    {

    }

    void CreateLowerBody()
    {
        for(int i = 0; i < NumberOfLowerBody; i++)
        {
            CreatureParts = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            CreatureParts.transform.position = new Vector3(i * 5, 0, 0);
            CreatureParts.transform.parent = Creature.transform;
            Nodes.Add(CreatureParts);
        }
    }

    void CreateLegs()
    {

    }
}
