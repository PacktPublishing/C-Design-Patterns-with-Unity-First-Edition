using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Transform OnxyDeposit;
    private TerrainFactory _factory;

    void Start()
    {
        _factory = new TerrainFactory();

        //var itemFactory = new ItemFactory();
        //List<Consumable> cart = new List<Consumable>();

        //for(int i = 0; i < 50; i++)
        //{
        //    var item = itemFactory.GetItem("Potion");
        //    item.Buy((Size)Random.Range(0,3), Random.Range(1, 10));

        //    //if (i % 2 == 0)
        //    //    cart.Add(itemFactory.GetItem("Potion"));
        //    //else
        //    //    cart.Add(itemFactory.GetItem("Antidote"));
        //}

        //foreach(var item in cart)
        //{
        //    int randomSize = Random.Range(0, 3);
        //    int randomCost = Random.Range(1, 10);
        //    item.Buy((Size)randomSize, randomCost);
        //}

        //StartCoroutine(HarvestResources());

        //List<Tile> tiles = new List<Tile>();
        //TileFactory factory = new TileFactory();

        //for(int i = 0; i < 10; i++)
        //{
        //    if (i % 2 == 0)
        //        tiles.Add(factory.GetTile("Hill"));
        //    else
        //        tiles.Add(factory.GetTile("Field"));
        //}

        //Debug.Log(factory.TilesCreated);

        //foreach(var tile in tiles)
        //{
        //    Debug.LogFormat($"{tile.Name}: x{tile.MovementCost} to move.");
        //}
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Onyx deposit")
                {
                    StartCoroutine(HarvestResources(OnxyDeposit.position));
                }
            }
        }
    }

    IEnumerator HarvestResources(Vector3 origin)
    {
        var resource = _factory.GetResource("Lumber");

        yield return new WaitForSeconds(0.05f);
        resource.Create(origin, Random.Range(1, 3));
        //resource.Mine(Random.Range(0, 10), origin);
    }
}