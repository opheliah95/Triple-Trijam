// GENERATED AUTOMATICALLY FROM 'Assets/InputAction/PlayerAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAction"",
    ""maps"": [
        {
            ""name"": ""Movements"",
            ""id"": ""c42903ed-39c4-49d9-906b-d66e6c7d89fd"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""d705bd7b-e50c-4c40-984a-a9a43fc8d54d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bac8db3b-4edf-43dc-8f19-40d8fdc629e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hold"",
                    ""type"": ""Button"",
                    ""id"": ""d8b0a5ec-75b5-46f6-9df8-3af8e486dfc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Value"",
                    ""id"": ""2315cab1-a816-457f-aabd-6d652ff1565d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""8c523ca3-413e-44a6-a810-cabe9ef5f7ea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Clap"",
                    ""type"": ""Button"",
                    ""id"": ""482d608d-abed-4df2-947a-2002aa26d63e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c43a153f-d668-4d4d-b810-5404da7f15b6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7769de75-9bac-4260-8df6-f49d9984b4b6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4b92af5d-a786-47ad-b503-0c00250d71f5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""083d734b-f252-499b-a56a-923abbe9cc36"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1df91189-b4ab-4cd7-80b8-b5d966da7e76"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0b8e602c-aff3-4587-b62f-b6c9092ee6a5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1511cddc-2eef-4463-bce2-5e6ece1b6f2a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""312fd123-6481-498d-a994-aa4fd7ac6423"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72c6f14d-63c7-4881-bba0-27e437eae726"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""424f3258-4860-44ee-ac0f-532e7d007e9e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Clap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""General"",
            ""id"": ""0d0170c6-ae21-4f09-be38-1029d5deb1af"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""a7dbf3a8-57ef-445d-9988-75867f227377"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7eda6c39-7633-4a17-bbb8-174ebd853758"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
        }
    ]
}");
        // Movements
        m_Movements = asset.FindActionMap("Movements", throwIfNotFound: true);
        m_Movements_Walk = m_Movements.FindAction("Walk", throwIfNotFound: true);
        m_Movements_Jump = m_Movements.FindAction("Jump", throwIfNotFound: true);
        m_Movements_Hold = m_Movements.FindAction("Hold", throwIfNotFound: true);
        m_Movements_Release = m_Movements.FindAction("Release", throwIfNotFound: true);
        m_Movements_Look = m_Movements.FindAction("Look", throwIfNotFound: true);
        m_Movements_Clap = m_Movements.FindAction("Clap", throwIfNotFound: true);
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_Exit = m_General.FindAction("Exit", throwIfNotFound: true);
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

    // Movements
    private readonly InputActionMap m_Movements;
    private IMovementsActions m_MovementsActionsCallbackInterface;
    private readonly InputAction m_Movements_Walk;
    private readonly InputAction m_Movements_Jump;
    private readonly InputAction m_Movements_Hold;
    private readonly InputAction m_Movements_Release;
    private readonly InputAction m_Movements_Look;
    private readonly InputAction m_Movements_Clap;
    public struct MovementsActions
    {
        private @PlayerAction m_Wrapper;
        public MovementsActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Movements_Walk;
        public InputAction @Jump => m_Wrapper.m_Movements_Jump;
        public InputAction @Hold => m_Wrapper.m_Movements_Hold;
        public InputAction @Release => m_Wrapper.m_Movements_Release;
        public InputAction @Look => m_Wrapper.m_Movements_Look;
        public InputAction @Clap => m_Wrapper.m_Movements_Clap;
        public InputActionMap Get() { return m_Wrapper.m_Movements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementsActions set) { return set.Get(); }
        public void SetCallbacks(IMovementsActions instance)
        {
            if (m_Wrapper.m_MovementsActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnWalk;
                @Jump.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnJump;
                @Hold.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnHold;
                @Hold.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnHold;
                @Hold.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnHold;
                @Release.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnRelease;
                @Look.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnLook;
                @Clap.started -= m_Wrapper.m_MovementsActionsCallbackInterface.OnClap;
                @Clap.performed -= m_Wrapper.m_MovementsActionsCallbackInterface.OnClap;
                @Clap.canceled -= m_Wrapper.m_MovementsActionsCallbackInterface.OnClap;
            }
            m_Wrapper.m_MovementsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Hold.started += instance.OnHold;
                @Hold.performed += instance.OnHold;
                @Hold.canceled += instance.OnHold;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Clap.started += instance.OnClap;
                @Clap.performed += instance.OnClap;
                @Clap.canceled += instance.OnClap;
            }
        }
    }
    public MovementsActions @Movements => new MovementsActions(this);

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_Exit;
    public struct GeneralActions
    {
        private @PlayerAction m_Wrapper;
        public GeneralActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_General_Exit;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @Exit.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IMovementsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnHold(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnClap(InputAction.CallbackContext context);
    }
    public interface IGeneralActions
    {
        void OnExit(InputAction.CallbackContext context);
    }
}
