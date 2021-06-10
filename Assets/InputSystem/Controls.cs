// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""83556d6c-0d60-4d77-b29f-f88e6027ac09"",
            ""actions"": [
                {
                    ""name"": ""MouseMovement"",
                    ""type"": ""Value"",
                    ""id"": ""75d697ec-9f47-40bd-bc02-b3a278c8b886"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DirectionalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c56f7915-f44a-423a-ac97-2bbc183bf397"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeScene"",
                    ""type"": ""Button"",
                    ""id"": ""5753138b-2422-4e6a-a1b9-7d584b10d18c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""a9a73129-2a40-4f5f-bc70-f76f75871048"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""a05a2665-003f-47ed-beee-45212d594229"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9058b63b-344b-4f17-8c45-46a244c64e14"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(y=-1),NormalizeVector2"",
                    ""groups"": ""PC"",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a50d401a-8c61-49f8-bc96-0c7ea9570823"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Consolas"",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d35c20c6-b045-458b-9e6a-d845b0955c04"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4141fd5d-dc84-49cb-925c-371ef9421a31"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e7faaf3b-baed-404e-b08d-1d9c3570d752"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9cccfa0c-e095-41f6-a77f-79add3d914e6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5daa376a-db1b-4992-bb35-6ee46a7aabef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d81b521a-71bd-411b-903b-2880152fb1a1"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Consolas"",
                    ""action"": ""DirectionalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abbde7df-9ce7-488c-a4e8-32495f630ae2"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ChangeScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68dc3cd0-df96-468b-82f9-f5d9e63b571d"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Consolas"",
                    ""action"": ""ChangeScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""906b66f0-c0f9-40a8-a186-de60db3a338a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8619f112-b64d-440e-9e92-8c6407787c00"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Consolas"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""678fa973-2d0d-4402-8dc1-e5781f9395b5"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afcdeb0e-6671-4630-b46f-ebbcc58da1a8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Consolas"",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Consolas"",
            ""bindingGroup"": ""Consolas"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MouseMovement = m_Player.FindAction("MouseMovement", throwIfNotFound: true);
        m_Player_DirectionalMovement = m_Player.FindAction("DirectionalMovement", throwIfNotFound: true);
        m_Player_ChangeScene = m_Player.FindAction("ChangeScene", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Skip = m_Player.FindAction("Skip", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MouseMovement;
    private readonly InputAction m_Player_DirectionalMovement;
    private readonly InputAction m_Player_ChangeScene;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Skip;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseMovement => m_Wrapper.m_Player_MouseMovement;
        public InputAction @DirectionalMovement => m_Wrapper.m_Player_DirectionalMovement;
        public InputAction @ChangeScene => m_Wrapper.m_Player_ChangeScene;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Skip => m_Wrapper.m_Player_Skip;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MouseMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseMovement;
                @MouseMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseMovement;
                @DirectionalMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionalMovement;
                @DirectionalMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionalMovement;
                @DirectionalMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDirectionalMovement;
                @ChangeScene.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeScene;
                @ChangeScene.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeScene;
                @ChangeScene.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeScene;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Skip.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkip;
                @Skip.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkip;
                @Skip.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkip;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseMovement.started += instance.OnMouseMovement;
                @MouseMovement.performed += instance.OnMouseMovement;
                @MouseMovement.canceled += instance.OnMouseMovement;
                @DirectionalMovement.started += instance.OnDirectionalMovement;
                @DirectionalMovement.performed += instance.OnDirectionalMovement;
                @DirectionalMovement.canceled += instance.OnDirectionalMovement;
                @ChangeScene.started += instance.OnChangeScene;
                @ChangeScene.performed += instance.OnChangeScene;
                @ChangeScene.canceled += instance.OnChangeScene;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Skip.started += instance.OnSkip;
                @Skip.performed += instance.OnSkip;
                @Skip.canceled += instance.OnSkip;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    private int m_ConsolasSchemeIndex = -1;
    public InputControlScheme ConsolasScheme
    {
        get
        {
            if (m_ConsolasSchemeIndex == -1) m_ConsolasSchemeIndex = asset.FindControlSchemeIndex("Consolas");
            return asset.controlSchemes[m_ConsolasSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMouseMovement(InputAction.CallbackContext context);
        void OnDirectionalMovement(InputAction.CallbackContext context);
        void OnChangeScene(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSkip(InputAction.CallbackContext context);
    }
}
