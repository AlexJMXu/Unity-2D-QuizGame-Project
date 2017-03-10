using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Question[] questions;
	private List<Question> unansweredQuestions;
	public static GameManager instance;

	private Question currentQuestion;

	[SerializeField] private Text factText;

	[SerializeField] private float timeBetweenQuestions = 1.5f;

	[SerializeField] private Text trueAnswerText;
	[SerializeField] private Text falseAnswerText;

	[SerializeField] private Animator animator;

	[SerializeField] private Button trueButton;
	[SerializeField] private Button falseButton;

	[SerializeField] private Canvas quizCanvas;
	[SerializeField] private Canvas endCanvas;
	[SerializeField] private Canvas startCanvas;

	private int score;

	void Awake() {
		if (instance != null) {
			Debug.LogError ("More than one GameManager in scene.");
		} else {
			instance = this;
		}
	}

	void Start() {
		score = 0;
		quizCanvas.gameObject.SetActive(false);
		endCanvas.gameObject.SetActive(false);
		startCanvas.gameObject.SetActive(true);
	}

	public void StartQuiz() {
		startCanvas.gameObject.SetActive(false);
		quizCanvas.gameObject.SetActive(true);
		Setup();
	}

	private void Setup() {
		if (unansweredQuestions == null || unansweredQuestions.Count == 0) {
			unansweredQuestions = questions.ToList<Question>();
		}

		SetCurrentQuestion();
	}

	private void SetCurrentQuestion() {
		int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions[randomQuestionIndex];

		factText.text = currentQuestion.fact;

		if (currentQuestion.isTrue) {
			trueAnswerText.text = "CORRECT!";
			falseAnswerText.text = "WRONG!";
		} else {
			trueAnswerText.text = "WRONG!";
			falseAnswerText.text = "CORRECT!";
		}
	}

	IEnumerator TransitionToNextQuestion() {
		unansweredQuestions.Remove(currentQuestion);

		yield return new WaitForSeconds(timeBetweenQuestions);

		animator.SetTrigger("None");

		yield return new WaitForSeconds(timeBetweenQuestions/5f);

		if (unansweredQuestions == null || unansweredQuestions.Count == 0) {
			EndOfQuiz();
			yield return true;
		}

		Setup();
		EnableButtons();
		
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	private void DisableButtons() {
		trueButton.GetComponent<CanvasGroup>().interactable = false;
		falseButton.GetComponent<CanvasGroup>().interactable = false;
	}

	private void EnableButtons() {
		trueButton.GetComponent<CanvasGroup>().interactable = true;
		falseButton.GetComponent<CanvasGroup>().interactable = true;
	}	

	public void UserSelectTrue() {
		animator.SetTrigger("True");
		DisableButtons();
		if (currentQuestion.isTrue) {
			score++;
		}
		StartCoroutine(TransitionToNextQuestion());
	}

	public void UserSelectFalse() {
		animator.SetTrigger("False");
		DisableButtons();
		if (!currentQuestion.isTrue) {
			score++;
		} 
		StartCoroutine(TransitionToNextQuestion());
	}

	public int GetScore() {
		return score;
	}

	private void EndOfQuiz() {
		quizCanvas.gameObject.SetActive(false);
		endCanvas.gameObject.SetActive(true);
		EndGame.instance.ShowScore(score, questions.Length);
	}

}
