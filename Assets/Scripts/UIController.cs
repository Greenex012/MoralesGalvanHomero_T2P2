using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    private GameObject[] _balls;

    private Vector3[] _initBallsTransform;

    [SerializeField] private ScoreManager _sManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _balls = GameObject.FindGameObjectsWithTag("Bola");

        _initBallsTransform = new Vector3[_balls.Length];

        for (int i = 0; i < _balls.Length; i++)
        {

            _initBallsTransform[i] = _balls[i].transform.position;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnReset()
    {

        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

    }

    public void BuyBalls()
    {

        if (_sManager.Score >= 100)
        {

            _sManager.Score -= 100;

            _sManager.UpdateScore();

            int i = 0;

            foreach (var ball in _balls)
            {

                ball.transform.position = _initBallsTransform[i];

                ball.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;

                ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

                i++;

            }


        }


    }

}
