using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private int enemyDistance = 0;
    private int enemyCount = 10;

    private string[] enemies = new string[6];

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            //EnemySearch();
            EnemyDestruction();
            EnemyRoster();

        }
    }

    void EnemySearch()
    {
        enemyDistance = Random.Range(1, 10);

        if (enemyDistance >= 8)
        {
            print("enemy is far away");
        }

        if (enemyDistance >= 4 && enemyDistance < 8)
        {
            print("enemy at a medium range");
        }

        if (enemyDistance < 4)
        {
            print("they are getting close");
        }

    }

    void EnemyDestruction()
    {

        while (enemyCount > 0)
        {
            print("There is an enemy !" + enemyCount);
            enemyCount--;
            // enemyCount = enemyCount - 1;
        }
    }

    void EnemyRoster()
    {
        enemies[0] = "Orc";
        enemies[1] = "Dragon";
        enemies[2] = "Dinosaur";
        enemies[3] = "Stegausorus";
        enemies[4] = "Tricerotops";
        enemies[5] = "Alosorus";

        foreach (string enemy in enemies)
        {
            print(enemy);
        }
    }




}