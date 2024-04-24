using UnityEngine;
public class InventoryActions : MonoBehaviour
{
    //Объект хранящий в себе слоты инвентаря
    [SerializeField] GameObject Slots;

    //Количество кликов 
    int clicksCounter = 0;

    //Проверка чётное или нечётное нажатие на иконку инвентаря и его открытие/закрытие
    public void Action()
    {
        if (clicksCounter % 2 == 0)
            Slots.SetActive(false);
        else
            Slots.SetActive(true);
    }

    //Счётчик кликов
    public void Clicked()
    {
        clicksCounter++;

    }

}
