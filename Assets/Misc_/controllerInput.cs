// GENERATED AUTOMATICALLY FROM 'Assets/Misc_/controllerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControllerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""controllerInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""17c67928-5448-42c1-9684-163c53ac5c3c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e49b5bfb-fb91-4413-8e01-9183f867b7b5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9e3114f4-2b5e-4482-be39-ec254bd7437e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ball"",
                    ""type"": ""Button"",
                    ""id"": ""44d3f36b-a59c-4044-a400-340eb55f9231"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""5de3571a-d964-48e4-9cd6-b653e2934b65"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""3b3762c7-6acd-4e2e-b444-b0fef5c13599"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hold"",
                    ""type"": ""Button"",
                    ""id"": ""ff3275bf-1cb6-430e-a624-a0bc6140c724"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sideStep"",
                    ""type"": ""Button"",
                    ""id"": ""d111d3c2-1e34-4f9e-9d2b-76e968990dee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""startGame"",
                    ""type"": ""Button"",
                    ""id"": ""61f0c9b0-9ecd-4410-b08d-79c407f20c4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mainMenu"",
                    ""type"": ""Button"",
                    ""id"": ""1d6ee03c-004f-4458-9447-1432a2f0ded4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""continueTutorial"",
                    ""type"": ""Button"",
                    ""id"": ""9b40b28b-2245-4ff0-951e-89b28cfaa437"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""d578f00a-e874-4574-90ac-7eacd8d2afea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""quit2"",
                    ""type"": ""Button"",
                    ""id"": ""42651a85-65df-4245-b24a-60e2370bcb9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""quit3"",
                    ""type"": ""Button"",
                    ""id"": ""ba2d0b22-2014-451f-93fa-e1eb40a6152f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""29e305dc-0a83-4c19-a906-5d7ff3783b06"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerOne"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a843edd-54a3-45a9-8a2a-f4636cea0a22"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerOne"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a3519d6-a2e3-449f-b007-141a90aba203"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerOne"",
                    ""action"": ""Ball"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f23698f-a3a1-4740-a9b4-5a086fe8c7e7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerOne"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5153285c-d645-4ed4-aa9c-5afd3ffbd045"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""275fdc3f-2f5c-4e35-8010-82bc397ac6cf"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a58c2a2a-1c60-4b0f-b4da-c98cfc0df10b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideStep"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42544007-3674-41f2-93d6-03b6c29f64ec"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerOne"",
                    ""action"": ""mainMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ba104d7-b3ad-46ea-ab56-f04507112f17"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerOne"",
                    ""action"": ""continueTutorial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfc76611-cbb9-49b6-a55f-ae849d5d5423"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17feec41-70b1-4378-8312-5d54a6f7884a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerOne"",
                    ""action"": ""quit2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7030f7e-eb93-47ec-a186-14502e758aff"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quit3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gameplay2"",
            ""id"": ""752be0f2-5726-4e26-9b03-e4caa534db1e"",
            ""actions"": [
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""ffb29c5c-b8b4-41f2-bea3-c6dfac21bf05"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ball"",
                    ""type"": ""Button"",
                    ""id"": ""89fcefb4-15dd-446e-8fd3-b871fe1d9541"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6189de47-f918-402b-ba97-3ade3b44af32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""fc9666cc-96f8-4947-8b7b-8b840ae18b39"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""1ea5264a-a185-4e22-94a0-71c12bbef2a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hold"",
                    ""type"": ""Button"",
                    ""id"": ""c9780d5f-b8cf-4fae-8f75-a15cb7040784"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sideStep"",
                    ""type"": ""Button"",
                    ""id"": ""c69b4c8e-a152-416a-ab49-bf6fea2195c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""quit2"",
                    ""type"": ""Button"",
                    ""id"": ""5e43e40b-da73-415f-bbe4-7bf28a10d09f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mainMenu"",
                    ""type"": ""Button"",
                    ""id"": ""6b0ff0df-a440-434c-b8b4-58a9ce654aee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""continueTutorial"",
                    ""type"": ""Button"",
                    ""id"": ""0b37e789-9135-4d84-9619-1cbfea9c15e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""9acbd825-51e2-4499-8b74-1b3b64c328cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""quit3"",
                    ""type"": ""Button"",
                    ""id"": ""17e82779-89e2-4568-8a0b-cab81dc64aac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ef83f9d-e7b1-4248-a7e4-7caf8df28a5f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33adf04c-6886-4508-ad6a-1cb0a723cdaf"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd851653-6cd9-4161-95c0-3d6fcb8766a7"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""Ball"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb14703f-ae10-488b-a53c-93215a15fbc6"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b82e7cc-fafe-45aa-ac70-810c3a12598e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75a97e26-46e7-4506-99c1-ab50dd840e61"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ef1180d-4706-405d-a311-c988c7db8eda"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sideStep"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20f6a8c2-0e2d-4b1e-96f0-1a6de764f42d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""quit2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1b62459-f918-4c86-8781-02e782ffde9d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""mainMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff395b09-e626-4217-bbdb-e73a9cf5b0bd"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""playerTwo"",
                    ""action"": ""continueTutorial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7de0e2b3-59cb-41a9-ab51-d4b69ce1fc8b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07874618-db98-4309-b7a2-9dadcbdbab97"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quit3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""playerOne"",
            ""bindingGroup"": ""playerOne"",
            ""devices"": []
        },
        {
            ""name"": ""playerTwo"",
            ""bindingGroup"": ""playerTwo"",
            ""devices"": []
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Ball = m_Gameplay.FindAction("Ball", throwIfNotFound: true);
        m_Gameplay_Camera = m_Gameplay.FindAction("Camera", throwIfNotFound: true);
        m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
        m_Gameplay_Hold = m_Gameplay.FindAction("Hold", throwIfNotFound: true);
        m_Gameplay_sideStep = m_Gameplay.FindAction("sideStep", throwIfNotFound: true);
        m_Gameplay_startGame = m_Gameplay.FindAction("startGame", throwIfNotFound: true);
        m_Gameplay_mainMenu = m_Gameplay.FindAction("mainMenu", throwIfNotFound: true);
        m_Gameplay_continueTutorial = m_Gameplay.FindAction("continueTutorial", throwIfNotFound: true);
        m_Gameplay_pause = m_Gameplay.FindAction("pause", throwIfNotFound: true);
        m_Gameplay_quit2 = m_Gameplay.FindAction("quit2", throwIfNotFound: true);
        m_Gameplay_quit3 = m_Gameplay.FindAction("quit3", throwIfNotFound: true);
        // Gameplay2
        m_Gameplay2 = asset.FindActionMap("Gameplay2", throwIfNotFound: true);
        m_Gameplay2_Camera = m_Gameplay2.FindAction("Camera", throwIfNotFound: true);
        m_Gameplay2_Ball = m_Gameplay2.FindAction("Ball", throwIfNotFound: true);
        m_Gameplay2_Jump = m_Gameplay2.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay2_Movement = m_Gameplay2.FindAction("Movement", throwIfNotFound: true);
        m_Gameplay2_Dash = m_Gameplay2.FindAction("Dash", throwIfNotFound: true);
        m_Gameplay2_Hold = m_Gameplay2.FindAction("Hold", throwIfNotFound: true);
        m_Gameplay2_sideStep = m_Gameplay2.FindAction("sideStep", throwIfNotFound: true);
        m_Gameplay2_quit2 = m_Gameplay2.FindAction("quit2", throwIfNotFound: true);
        m_Gameplay2_mainMenu = m_Gameplay2.FindAction("mainMenu", throwIfNotFound: true);
        m_Gameplay2_continueTutorial = m_Gameplay2.FindAction("continueTutorial", throwIfNotFound: true);
        m_Gameplay2_pause = m_Gameplay2.FindAction("pause", throwIfNotFound: true);
        m_Gameplay2_quit3 = m_Gameplay2.FindAction("quit3", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Movement;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Ball;
    private readonly InputAction m_Gameplay_Camera;
    private readonly InputAction m_Gameplay_Dash;
    private readonly InputAction m_Gameplay_Hold;
    private readonly InputAction m_Gameplay_sideStep;
    private readonly InputAction m_Gameplay_startGame;
    private readonly InputAction m_Gameplay_mainMenu;
    private readonly InputAction m_Gameplay_continueTutorial;
    private readonly InputAction m_Gameplay_pause;
    private readonly InputAction m_Gameplay_quit2;
    private readonly InputAction m_Gameplay_quit3;
    public struct GameplayActions
    {
        private @ControllerInput m_Wrapper;
        public GameplayActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Ball => m_Wrapper.m_Gameplay_Ball;
        public InputAction @Camera => m_Wrapper.m_Gameplay_Camera;
        public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
        public InputAction @Hold => m_Wrapper.m_Gameplay_Hold;
        public InputAction @sideStep => m_Wrapper.m_Gameplay_sideStep;
        public InputAction @startGame => m_Wrapper.m_Gameplay_startGame;
        public InputAction @mainMenu => m_Wrapper.m_Gameplay_mainMenu;
        public InputAction @continueTutorial => m_Wrapper.m_Gameplay_continueTutorial;
        public InputAction @pause => m_Wrapper.m_Gameplay_pause;
        public InputAction @quit2 => m_Wrapper.m_Gameplay_quit2;
        public InputAction @quit3 => m_Wrapper.m_Gameplay_quit3;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Ball.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBall;
                @Ball.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBall;
                @Ball.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBall;
                @Camera.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCamera;
                @Dash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                @Hold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @Hold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @Hold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnHold;
                @sideStep.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSideStep;
                @sideStep.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSideStep;
                @sideStep.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSideStep;
                @startGame.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartGame;
                @startGame.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartGame;
                @startGame.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStartGame;
                @mainMenu.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMainMenu;
                @mainMenu.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMainMenu;
                @mainMenu.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMainMenu;
                @continueTutorial.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnContinueTutorial;
                @continueTutorial.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnContinueTutorial;
                @continueTutorial.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnContinueTutorial;
                @pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @quit2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit2;
                @quit2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit2;
                @quit2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit2;
                @quit3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit3;
                @quit3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit3;
                @quit3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnQuit3;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Ball.started += instance.OnBall;
                @Ball.performed += instance.OnBall;
                @Ball.canceled += instance.OnBall;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Hold.started += instance.OnHold;
                @Hold.performed += instance.OnHold;
                @Hold.canceled += instance.OnHold;
                @sideStep.started += instance.OnSideStep;
                @sideStep.performed += instance.OnSideStep;
                @sideStep.canceled += instance.OnSideStep;
                @startGame.started += instance.OnStartGame;
                @startGame.performed += instance.OnStartGame;
                @startGame.canceled += instance.OnStartGame;
                @mainMenu.started += instance.OnMainMenu;
                @mainMenu.performed += instance.OnMainMenu;
                @mainMenu.canceled += instance.OnMainMenu;
                @continueTutorial.started += instance.OnContinueTutorial;
                @continueTutorial.performed += instance.OnContinueTutorial;
                @continueTutorial.canceled += instance.OnContinueTutorial;
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @quit2.started += instance.OnQuit2;
                @quit2.performed += instance.OnQuit2;
                @quit2.canceled += instance.OnQuit2;
                @quit3.started += instance.OnQuit3;
                @quit3.performed += instance.OnQuit3;
                @quit3.canceled += instance.OnQuit3;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Gameplay2
    private readonly InputActionMap m_Gameplay2;
    private IGameplay2Actions m_Gameplay2ActionsCallbackInterface;
    private readonly InputAction m_Gameplay2_Camera;
    private readonly InputAction m_Gameplay2_Ball;
    private readonly InputAction m_Gameplay2_Jump;
    private readonly InputAction m_Gameplay2_Movement;
    private readonly InputAction m_Gameplay2_Dash;
    private readonly InputAction m_Gameplay2_Hold;
    private readonly InputAction m_Gameplay2_sideStep;
    private readonly InputAction m_Gameplay2_quit2;
    private readonly InputAction m_Gameplay2_mainMenu;
    private readonly InputAction m_Gameplay2_continueTutorial;
    private readonly InputAction m_Gameplay2_pause;
    private readonly InputAction m_Gameplay2_quit3;
    public struct Gameplay2Actions
    {
        private @ControllerInput m_Wrapper;
        public Gameplay2Actions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_Gameplay2_Camera;
        public InputAction @Ball => m_Wrapper.m_Gameplay2_Ball;
        public InputAction @Jump => m_Wrapper.m_Gameplay2_Jump;
        public InputAction @Movement => m_Wrapper.m_Gameplay2_Movement;
        public InputAction @Dash => m_Wrapper.m_Gameplay2_Dash;
        public InputAction @Hold => m_Wrapper.m_Gameplay2_Hold;
        public InputAction @sideStep => m_Wrapper.m_Gameplay2_sideStep;
        public InputAction @quit2 => m_Wrapper.m_Gameplay2_quit2;
        public InputAction @mainMenu => m_Wrapper.m_Gameplay2_mainMenu;
        public InputAction @continueTutorial => m_Wrapper.m_Gameplay2_continueTutorial;
        public InputAction @pause => m_Wrapper.m_Gameplay2_pause;
        public InputAction @quit3 => m_Wrapper.m_Gameplay2_quit3;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Gameplay2Actions set) { return set.Get(); }
        public void SetCallbacks(IGameplay2Actions instance)
        {
            if (m_Wrapper.m_Gameplay2ActionsCallbackInterface != null)
            {
                @Camera.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnCamera;
                @Ball.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnBall;
                @Ball.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnBall;
                @Ball.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnBall;
                @Jump.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnMovement;
                @Dash.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnDash;
                @Hold.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnHold;
                @Hold.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnHold;
                @Hold.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnHold;
                @sideStep.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnSideStep;
                @sideStep.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnSideStep;
                @sideStep.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnSideStep;
                @quit2.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnQuit2;
                @quit2.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnQuit2;
                @quit2.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnQuit2;
                @mainMenu.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnMainMenu;
                @mainMenu.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnMainMenu;
                @mainMenu.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnMainMenu;
                @continueTutorial.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnContinueTutorial;
                @continueTutorial.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnContinueTutorial;
                @continueTutorial.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnContinueTutorial;
                @pause.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnPause;
                @quit3.started -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnQuit3;
                @quit3.performed -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnQuit3;
                @quit3.canceled -= m_Wrapper.m_Gameplay2ActionsCallbackInterface.OnQuit3;
            }
            m_Wrapper.m_Gameplay2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Ball.started += instance.OnBall;
                @Ball.performed += instance.OnBall;
                @Ball.canceled += instance.OnBall;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Hold.started += instance.OnHold;
                @Hold.performed += instance.OnHold;
                @Hold.canceled += instance.OnHold;
                @sideStep.started += instance.OnSideStep;
                @sideStep.performed += instance.OnSideStep;
                @sideStep.canceled += instance.OnSideStep;
                @quit2.started += instance.OnQuit2;
                @quit2.performed += instance.OnQuit2;
                @quit2.canceled += instance.OnQuit2;
                @mainMenu.started += instance.OnMainMenu;
                @mainMenu.performed += instance.OnMainMenu;
                @mainMenu.canceled += instance.OnMainMenu;
                @continueTutorial.started += instance.OnContinueTutorial;
                @continueTutorial.performed += instance.OnContinueTutorial;
                @continueTutorial.canceled += instance.OnContinueTutorial;
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @quit3.started += instance.OnQuit3;
                @quit3.performed += instance.OnQuit3;
                @quit3.canceled += instance.OnQuit3;
            }
        }
    }
    public Gameplay2Actions @Gameplay2 => new Gameplay2Actions(this);
    private int m_playerOneSchemeIndex = -1;
    public InputControlScheme playerOneScheme
    {
        get
        {
            if (m_playerOneSchemeIndex == -1) m_playerOneSchemeIndex = asset.FindControlSchemeIndex("playerOne");
            return asset.controlSchemes[m_playerOneSchemeIndex];
        }
    }
    private int m_playerTwoSchemeIndex = -1;
    public InputControlScheme playerTwoScheme
    {
        get
        {
            if (m_playerTwoSchemeIndex == -1) m_playerTwoSchemeIndex = asset.FindControlSchemeIndex("playerTwo");
            return asset.controlSchemes[m_playerTwoSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBall(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnHold(InputAction.CallbackContext context);
        void OnSideStep(InputAction.CallbackContext context);
        void OnStartGame(InputAction.CallbackContext context);
        void OnMainMenu(InputAction.CallbackContext context);
        void OnContinueTutorial(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnQuit2(InputAction.CallbackContext context);
        void OnQuit3(InputAction.CallbackContext context);
    }
    public interface IGameplay2Actions
    {
        void OnCamera(InputAction.CallbackContext context);
        void OnBall(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnHold(InputAction.CallbackContext context);
        void OnSideStep(InputAction.CallbackContext context);
        void OnQuit2(InputAction.CallbackContext context);
        void OnMainMenu(InputAction.CallbackContext context);
        void OnContinueTutorial(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnQuit3(InputAction.CallbackContext context);
    }
}
