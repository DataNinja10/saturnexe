using CloudyApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saturn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Verificar si el color de fondo de Form1 es ControlDarkDark
            if (Form1.Instance.BackColor == System.Drawing.Color.Gray)
            {
                // Si es ControlDarkDark, cambiar el color de fondo de Form2
                this.BackColor = System.Drawing.Color.Gray;
                button1.BackColor = System.Drawing.Color.Gray;
                a.BackColor = System.Drawing.Color.Gray;
                Betterbypasser.BackColor = System.Drawing.Color.Gray;
                AnimationHub.BackColor = System.Drawing.Color.Gray;
                button4.BackColor = System.Drawing.Color.Gray;
                Nameless.BackColor = System.Drawing.Color.Gray;
                quirkycmd.BackColor = System.Drawing.Color.Gray;

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Api.execute("local player = game.Players.LocalPlayer\r\nlocal mouse = player:GetMouse()\r\nlocal userInputService = game:GetService(\"UserInputService\")\r\n\r\nlocal gui = Instance.new(\"ScreenGui\")\r\nlocal button = Instance.new(\"TextButton\")\r\n\r\ngui.Parent = player:FindFirstChild(\"PlayerGui\") or player:WaitForChild(\"PlayerGui\")\r\n\r\nbutton.Parent = gui\r\nbutton.Size = UDim2.new(0, 100, 0, 50)\r\nbutton.Position = UDim2.new(0.1, 0, 0.1, 0)\r\nbutton.Text = \"Toggle\"\r\nbutton.BackgroundColor3 = Color3.fromRGB(50, 150, 250)\r\nbutton.TextColor3 = Color3.new(1, 1, 1)\r\nbutton.Font = Enum.Font.SourceSansBold\r\nbutton.TextSize = 20\r\nbutton.BorderSizePixel = 2\r\nbutton.BorderColor3 = Color3.new(0, 0, 0)\r\n\r\nlocal enabled = true\r\nlocal ctrlHeld = false  -- Para saber si \"Ctrl\" está presionado\r\n\r\n-- Cambia el estado del teletransporte al hacer clic en el botón\r\nbutton.MouseButton1Click:Connect(function()\r\n    enabled = not enabled\r\n    button.BackgroundColor3 = enabled and Color3.fromRGB(50, 150, 250) or Color3.fromRGB(150, 50, 50)\r\nend)\r\n\r\n-- Detecta si \"Ctrl\" está presionado o soltado\r\nuserInputService.InputBegan:Connect(function(input, gameProcessed)\r\n    if input.KeyCode == Enum.KeyCode.LeftControl or input.KeyCode == Enum.KeyCode.RightControl then\r\n        ctrlHeld = true\r\n    end\r\nend)\r\n\r\nuserInputService.InputEnded:Connect(function(input, gameProcessed)\r\n    if input.KeyCode == Enum.KeyCode.LeftControl or input.KeyCode == Enum.KeyCode.RightControl then\r\n        ctrlHeld = false\r\n    end\r\nend)\r\n\r\n-- Teletransporte solo si \"Ctrl\" está presionado y el script está activado\r\nmouse.Button1Down:Connect(function()\r\n    if enabled and ctrlHeld and player.Character and player.Character:FindFirstChild(\"HumanoidRootPart\") then\r\n        local targetPosition = mouse.Hit.p\r\n        local humanoidRootPart = player.Character.HumanoidRootPart\r\n        humanoidRootPart.CFrame = CFrame.new(targetPosition + Vector3.new(0, 3, 0))\r\n    end\r\nend)\r\n");
        }
        private void a_Click(object sender, EventArgs e)
        {
            Api.execute("loadstring(game:HttpGet(\"https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source\"))()");
        }

        private void Betterbypasser_Click(object sender, EventArgs e)
        {
            Api.execute("loadstring(game:HttpGet(\"https://github.com/Synergy-Networks/products/raw/main/BetterBypasser/loader.lua\"))()\r\n");
        }

        private void AnimationHub_Click(object sender, EventArgs e)
        {
            Api.execute("loadstring(game:HttpGet(\"https://pastebin.com/raw/rL0SfBA1\"))()");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Api.execute("loadstring(game:HttpGet(\"https://pastebin.com/raw/FWwdST5Y\"))()");
        }

        private void Nameless_Click(object sender, EventArgs e)
        {
            Api.execute("loadstring(game:HttpGet('https://raw.githubusercontent.com/FilteringEnabled/NamelessAdmin/main/Source'))()");
        }

        private void quirkycmd_Click(object sender, EventArgs e)
        {
            Api.execute("loadstring(game:HttpGet(\"https://gist.github.com/someunknowndude/38cecea5be9d75cb743eac8b1eaf6758/raw\"))()\r\n");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}