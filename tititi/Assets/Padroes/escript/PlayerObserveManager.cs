
using System;

public class PlayerObserveManager
{
        //permite que um usuario se invreva no canal (analogia youtube)
        public static event Action<int> OnPlayerChanged;

        //permite que o craidor de conteudo mande video novo
        public static void PlayerChanged(int volume)
        {
            //permite que os inscritos mande notificação
            OnPlayerChanged?.Invoke(volume);
        }
}
