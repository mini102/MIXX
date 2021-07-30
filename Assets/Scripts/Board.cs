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
    private Tile[,] m_TilesArray = new Tile[6, 6];
    private Dictionary<string, Tile> m_TilesDictionary = new Dictionary<string, Tile>();
    private GameObject tilePrefab;
    public int m_Width = 4;
    public int m_Height = 4;
    // Start is called before the first frame update
    void Start()
    {
        //Tile tile_0 = Instantiate<Tile>(tilePrefab.transform.GetComponent<Tile>());
        //tile_0.transform.position = Vector3.zero;
        //tile_0.transform.SetParent(this.transform);
        CreateTiles();
    }

    private void CreateTiles()
    {
        int number = 0;
        for (int x = 0; x < m_Width; x++)
        {
            //Random rand = new Random();
            for (int y = 0; y < m_Height; y++)
            {
                number = Random.Range(0, 16);//rand.Next(15);  //0~15
                Debug.Log("random: " + number.ToString());
                //key= 0,0
                string key = x.ToString() + "," + y.ToString();
                switch (number)
                {
                    case 0 :
                      tilePrefab = Resources.Load("Prefabs/CandyPurple") as GameObject;
                      break;
                    case 1:
                       tilePrefab = Resources.Load("Prefabs/candy_3b") as GameObject;
                       break;
                    case 2:
                        tilePrefab = Resources.Load("Prefabs/candy_3g") as GameObject;
                        break;
                    case 3:
                        tilePrefab = Resources.Load("Prefabs/candy_3o") as GameObject;
                        break;
                    case 4:
                        tilePrefab = Resources.Load("Prefabs/candy_3p") as GameObject;
                        break;
                    case 5:
                        tilePrefab = Resources.Load("Prefabs/candy_beanr") as GameObject;
                        break;
                    case 6:
                        tilePrefab = Resources.Load("Prefabs/candy_beany") as GameObject;
                        break;
                    case 7:
                        tilePrefab = Resources.Load("Prefabs/candy_bloomblue") as GameObject;
                        break;
                    case 8:
                        tilePrefab = Resources.Load("Prefabs/candy_bloomp") as GameObject;
                        break;
                    case 9:
                        tilePrefab = Resources.Load("Prefabs/candy_recb") as GameObject;
                        break;
                    case 10:
                        tilePrefab = Resources.Load("Prefabs/candy_recg") as GameObject;
                        break;
                    case 11:
                        tilePrefab = Resources.Load("Prefabs/candy_reco") as GameObject;
                        break;
                    case 12:
                        tilePrefab = Resources.Load("Prefabs/candy_recp") as GameObject;
                        break;
                    case 13:
                        tilePrefab = Resources.Load("Prefabs/candy_recr") as GameObject;
                        break;
                    case 14:
                        tilePrefab = Resources.Load("Prefabs/candy_recy") as GameObject;
                        break;
                }
                Tile tile = Instantiate<Tile>(tilePrefab.transform.GetComponent<Tile>());

                tile.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                tile.transform.SetParent(this.transform);
                tile.transform.position = new Vector3(x, y, 0f);

                m_TilesDictionary.Add(key, tile);
            }
        }
    }

    public Tile GetTile(int x, int y)
    {
        string key = x.ToString() + "," + y.ToString();
        return m_TilesDictionary[key];
    }

    public Tile GetTile(string xy)
    {
        return m_TilesDictionary[xy];
    }
}
