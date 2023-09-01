using System;
using System.Windows.Forms;
using NAudio.Wave;  // Biblioteca NAudio para reprodução de áudio MP3

namespace PomodoroApp
{
    public partial class Form1 : Form
    {
        // Declaração de variáveis de estado
        private Timer cronometro;  // Timer para controlar o tempo
        private int segundosRestantes;  // Tempo restante em segundos
        private bool estaRodando;  // Indica se o cronômetro está rodando

        // Inicialização do Form
        public Form1()
        {
            InitializeComponent();
            ConfigurarPomodoro();
        }

        // Configuração inicial do cronômetro Pomodoro
        private void ConfigurarPomodoro()
        {
            cronometro = new Timer();
            cronometro.Interval = 1000;  // Intervalo de 1 segundo
            cronometro.Tick += AtualizarTempo;  // Evento para atualizar o tempo
            estaRodando = false;  // O cronômetro começa parado
        }

        // Ação para o botão "Iniciar/Pausar"
        private void btIniciar_Click(object sender, EventArgs e)
        {
            AlternarCronometro();
        }

        // Alternar entre Iniciar e Pausar o cronômetro
        private void AlternarCronometro()
        {
            if (nmTempo.Value == 0)
            {
                MessageBox.Show("Favor informar o tempo!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Error);
                nmTempo.Focus();
                return;
            }

            if (estaRodando)
            {
                cronometro.Stop();
                btIniciar.Text = "Iniciar";
            }
            else
            {
                segundosRestantes = (int)nmTempo.Value * 60;  // Converte minutos para segundos
                pgBar.Maximum = segundosRestantes;
                pgBar.Value = segundosRestantes;
                AtualizarPercentual();
                cronometro.Start();
                btIniciar.Text = "Pausar";
            }
            estaRodando = !estaRodando;
        }

        // Atualiza o tempo e a interface do usuário
        private void AtualizarTempo(object sender, EventArgs e)
        {
            segundosRestantes--;
            pgBar.Value = segundosRestantes;
            AtualizarPercentual();

            if (segundosRestantes <= 0)
            {
                cronometro.Stop();
                TocarAudio();
                btIniciar.Text = "Iniciar";
                estaRodando = false;
            }
        }

        // Atualiza o percentual na interface do usuário
        private void AtualizarPercentual()
        {
            double percentual = ((double)pgBar.Value / (double)pgBar.Maximum) * 100;
            lbPercentual.Text = $"{Math.Round(percentual, 2)}%";
        }

        // Reproduz o áudio ao final do cronômetro
        private void TocarAudio()
        {
            using (var leitorMp3 = new Mp3FileReader("C:/Users/Acer/Desktop/C#/Pomodoro/Pomodoro/sino.mp3"))
            {
                using (var saidaDeOnda = new WaveOutEvent())
                {
                    saidaDeOnda.Init(leitorMp3);
                    saidaDeOnda.Play();
                    while (saidaDeOnda.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
        }
    }
}
