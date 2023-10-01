using System;
using System.Collections;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    [SerializeField] private GameObject[] skillPrefabs;
    [SerializeField] private Transform enemy;

    private IEnumerator currentCoroutine;
    private void Start()
    {
        currentCoroutine = UseSkills(skillPrefabs, enemy.position, 2f);
        //StartCoroutine(currentCoroutine);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if(currentCoroutine != null)
                StopCoroutine(currentCoroutine);
        }
    }

    IEnumerator UseSkills(GameObject[] skills,Vector3 destination, float delay)
    {
        foreach (var skill in skills)
        {
            var createdSkill = Instantiate(skill, transform.position, Quaternion.identity);

            while (createdSkill.transform.position != destination)
            {
                createdSkill.transform.position =
                    Vector3.MoveTowards(createdSkill.transform.position, destination, 2 * Time.deltaTime);
                yield return null;
            }
            
            yield return new WaitForSeconds(delay);
        }
    }
}