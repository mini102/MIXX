using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //[0,0][1,0][2,0][3,0][4,0][5,0]
    //[0][1][2][3][4][5]
    //[0][1][2][3][4][5]
    //[0][1][2][3][4][5]
    //[0][1][2][3][4][5]
    //[0,5][1][2][3][4][5]
    private Tile[,] m_TilesArray = new Tile[6,6];
    private Dictionary<string,Tile> m_TilesDictionary = new Dictionary<string, Tile>();
    private GameObject tilePrefab;
    public int m_Width = 4;
    public int m_Height = 4;
    // Start is called before the first frame update
    void Start() 
    {
        tilePrefab = Resources.Load("Prefabs/CandyPurple") as GameObject;
        //Tile tile_0 = Instantiate<Tile>(tilePrefab.transform.GetComponent<Tile>());
        //tile_0.transform.position = Vector3.zero;
        //tile_0.transform.SetParent(this.transform);
        CreateTiles();
    }

    private void CreateTiles()
    { 
        for(int x = 0; x < m_Width; x++)
        {
            for (int y = 0; y < m_Height; y++)
            {
                //key= 0,0
                string key = x.ToString() +","+ y.ToString();
                Tile tile = Instantiate<Tile>(tilePrefab.transform.GetComponent<Tile>());
                
                tile.transform.SetParent(this.transform);
                tile.transform.position = new Vector3(x,y,0f);

                m_TilesDictionary.Add(key, tile);
            }
        }
    }
}
