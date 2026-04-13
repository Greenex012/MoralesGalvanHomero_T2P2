using UnityEngine;

public class Lata : MonoBehaviour
{
    [SerializeField] private int _points = 100;

    public int Points { get => _points; set => _points = value; }

}
