using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class scean2 : MonoBehaviour
{
    public int l = 2;

    public void menuscene()
    {

        SceneManager.LoadScene("2_menu");
    }
    public void stage1start()
    {
        SceneManager.LoadScene("stage1");
    }
    public void mapscene()
    {
        TextManager.Fail1 = false;
        TextManager.Fail5 = false;
        TextManager.t = false;
        TextManager.h = false;
        TextManager.Fail1 = false;
        TextManager.TileA = 0;
        TextManager.TileB = 0;
        SceneManager.LoadScene("map");
    }
    public void story()
    {
        SceneManager.LoadScene("stroy");
    }

    public void restart()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage1");
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage2");
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage3");
        }
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage4");
        }
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage5");
        }
        if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage6");
        }
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage7");
        }
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage8");
        }
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage9");
        }
        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage10");
        }
        if (SceneManager.GetActiveScene().buildIndex == 13)
        {
            TextManager.Fail1 = false;
            TextManager.Fail5 = false;
            TextManager.t = false;
            TextManager.h = false;
            TextManager.Fail1 = false;
            TextManager.TileA = 0;
            TextManager.TileB = 0;
            SceneManager.LoadScene("stage11");
        }
    }

}
