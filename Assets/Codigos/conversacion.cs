
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conversacion : MonoBehaviour
{
    [SerializeField] GameObject msgPanel;
    [SerializeField] Text msgText;
    [SerializeField] GameObject msgPanelTareas;
    [SerializeField] Text msgTarea1;
    [SerializeField] Text msgTarea2;
    [SerializeField] Text msgTarea3;
   
    public int Puntaje = 20;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
        msgPanel.SetActive(false);
        msgPanelTareas.SetActive(true);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Secre")
        {
            
            msgText.text = "Secretaria : 'Hola en que puedo ayudarte ' \n"+
                "Estudiante : 'Buenas ,deseo saber el proceso para el record academico' ";
            //msgText.text = "Secretaria : 'Concedame su codigo'                                                    " +
            //    "Estudiante : 'encantado es el ' " + stringCode ;
            //msgText.text = "Secretaria : 'Espereme un rato por favor ya le entrego el record academico'                                                    " +
            //    "Estudiante : 'muchas gracias estare pendiente " ;

            msgPanel.SetActive(true);
            msgPanelTareas.SetActive(false);
            GameControler.Gamecontroller.ScoreN += Puntaje+30;
        }
        if (other.name == "secretaria11")
        {
           
            msgText.text = "Estudiante :'Buenas Tardes ,disculpe se encuentra el Ingeniero Patrico Moreno ?' \n" +
                "Secretaria: 'Si se encuentra por el momento esa ocupado pero esperele nomas'";
            msgPanel.SetActive(true);
            msgPanelTareas.SetActive(false);
            GameControler.Gamecontroller.ScoreN += Puntaje+50;
        }
        if (other.name == "Marca1")
        {

            msgText.text = "Esta debe ser una de las marcas ...analizemos con la app";
            msgPanel.SetActive(true);
            msgPanelTareas.SetActive(false);
            GameControler.Gamecontroller.ScoreN += Puntaje + 50;
        }
        if (other.name == "Marca2")
        {

            msgText.text = "La segunda marca. Genial¡¡¡¡";
            msgPanel.SetActive(true);
            msgPanelTareas.SetActive(false);
            GameControler.Gamecontroller.ScoreN += Puntaje + 50;
        }
        if (other.name == "NPC_Consere ")
        {
            msgText.text = "Conserje:Deseas hacer una mision de busqueda ?\n " +
                "Estudiante : Si encantado¡¡\n" +
                "Conserje: Deberas encontrar dos marcas de Realidad Aumentada y con la app escanearlas";
            msgPanel.SetActive(true);
            msgPanelTareas.SetActive(false);
            GameControler.Gamecontroller.ScoreN += Puntaje + 20;
        }

        if (other.name == "LibroT1" || other.name == "Cube1")
        {
           
            msgText.text = "Es verdad esto debo llevarlo a secretetaria!! ";
            msgPanel.SetActive(true);
            msgPanelTareas.SetActive(false);
            GameControler.Gamecontroller.ScoreN += Puntaje-10;
        }
        if (other.name == "LibroT2")
        {
           
            msgText.text = "Documentos?... es cierto tengo que entregarlos ";
            msgPanel.SetActive(true);
            msgPanelTareas.SetActive(false);
            GameControler.Gamecontroller.ScoreN += Puntaje-10;
        }
        if (other.name == "LibroT3")
        {
          
            msgText.text = "Necesito una firma en estos documentos ...  ";
            msgPanel.SetActive(true);
            msgPanelTareas.SetActive(false);
            GameControler.Gamecontroller.ScoreN += Puntaje-10;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Secre"  )
        {
            msgPanel.SetActive(false);
            msgPanelTareas.SetActive(true);
            msgTarea2.color = new Color(0,255, 0,1.0F);

        }
        if (other.name == "Marca1" || other.name == "Marca2")
        {
            msgPanel.SetActive(false);
            msgPanelTareas.SetActive(true);
            //msgTarea2.color = new Color(0, 255, 0, 1.0F);

        }


        if (other.name == "secretaria11")
        {
            msgPanel.SetActive(false);
            msgPanelTareas.SetActive(true);
            msgTarea3.color = new Color(0, 255, 0, 1.0F);
        }
        if (other.name == "LibroT1" || other.name == "Cube1")
        {
            msgPanel.SetActive(false);
            msgPanelTareas.SetActive(true);
            msgTarea1.color = new Color(0, 255, 0, 1.0F);
        }
        if(other.name == "LibroT2" || other.name =="NPC_Consere")
        {
            msgPanel.SetActive(false);
            msgPanelTareas.SetActive(true);
            msgTarea1.color = new Color(0, 255, 0, 1.0F);
        }
        if (other.name == "LibroT3")
        {
            msgPanel.SetActive(false);
            msgPanelTareas.SetActive(true);
            msgTarea1.color = new Color(0, 255, 0, 1.0F);
        }
    }
 
   
   
}
