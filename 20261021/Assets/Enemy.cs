using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private MonsterStats _stats;
    [SerializeField] private int _id;
    /* csv parser
    [SerializeField] private EnemyDataParser _parser;
    [SerializeField] private EnemyData _data;
    */

    private void Start()
    {
        // csv parser
        //_parser.TryGetEnemy(_id, out _data);

        _id = _stats.ID;

        Debug.Log(_id);
    }
}
