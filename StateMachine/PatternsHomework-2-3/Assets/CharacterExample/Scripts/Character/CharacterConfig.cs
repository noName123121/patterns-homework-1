using UnityEngine;

[CreateAssetMenu(menuName = "Configs/CharacterConfig", fileName = "CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [field: SerializeField] public WalkingStateConfig WalkingStateConfig { get; private set; }
    [field: SerializeField] public RunningStateConfig RunningStateConfig { get; private set; }
    [field: SerializeField] public SprintingStateConfig SprintingStateConfig { get; private set; }
    [field: SerializeField] public AirbornStateConfig AirbornStateConfig { get; private set; }
}
