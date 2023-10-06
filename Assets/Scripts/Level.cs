using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Level : MonoBehaviour
{
    public GameObject emptyTile;
    public GameObject outsideCornerTile;
    public GameObject outsideWallTile;
    public GameObject insideCornerTile;
    public GameObject insideWallTile;
    public GameObject standardPelletTile;
    public GameObject powerPelletTile;
    public GameObject junctionTile; 

    int[,] levelMap =
 {
 {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
 {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
 {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
 {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
 {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
 {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
 {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
 {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
 {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
 {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
 {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
 };

    // Start is called before the first frame update
    void Start()
    {
        GenerateLevel();   
    }
    
    void GenerateLevel()
    {
        for (int x=0; x<levelMap.GetLength(0); x++)
        {
            for(int y=0; y < levelMap.GetLength(0); y++) 
            {
                int tileIndex = levelMap[x, y];
                GameObject tilePrefab = GetTilePrefabForIndex(tileIndex);

                if(tilePrefab != null)
                {
                    Vector3Int tilePosition = new Vector3Int(x, -y, 0);
                    Instantiate(tilePrefab, tilePosition, Quaternion.identity);
                }
            }
        }
    }
    
    GameObject GetTilePrefabForIndex(int index)
    {
        switch(index)
        {
            case 0: return emptyTile;
            case 1: return outsideCornerTile;
            case 2: return outsideWallTile;
            case 3: return insideCornerTile;
            case 4: return insideWallTile;
            case 5: return standardPelletTile;
            case 6: return powerPelletTile;
            case 7: return junctionTile;
            default: return null;
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
