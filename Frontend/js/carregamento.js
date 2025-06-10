// Aguarda o conteúdo da página carregar completamente antes de rodar o script
document.addEventListener('DOMContentLoaded', () => {

  const progressBar = document.getElementById('progressBar');
  const statusMessage = document.getElementById('statusMessage');

  const messages = [
    "Calculando suas necessidades diárias de calorias e nutrientes...",
    "Analisando seu índice de massa corporal (IMC)...",
    "Gerando um plano alimentar personalizado para você..."
  ];

  let progress = 0;
  let msgIndex = 0;

  // Função para atualizar a mensagem com efeito de fade
  const updateMessage = (newText) => {
    statusMessage.classList.add('fade-out');
    
    // Aguarda o fim da transição de fade-out para trocar o texto
    setTimeout(() => {
      statusMessage.textContent = newText;
      statusMessage.classList.remove('fade-out');
    }, 600); // Este tempo deve ser igual ao tempo da transição no CSS
  };

  // Intervalo para simular o carregamento
  const interval = setInterval(() => {
    progress += 1;
    progressBar.style.width = `${progress}%`;

    // Troca a mensagem em 33% e 66% do progresso
    if (progress === 33) {
        updateMessage(messages[0]);
    }
    
    if (progress === 66) {
        updateMessage(messages[1]);
    }

    // Finaliza o carregamento
    if (progress >= 100) {
      clearInterval(interval);
      // A última mensagem do array é chamada aqui
      updateMessage(messages[2]);
      
      // Simula um redirecionamento após a conclusão
      setTimeout(() => {
        // Altere a linha abaixo para o link da sua página de resultados
        // window.location.href = "/pagina-de-resultados.html"; 
        console.log("Redirecionando para a página de resultados...");
      }, 2000); // Espera 2 segundos antes de redirecionar
    }
  }, 80); // Ajustado para um carregamento de aproximadamente 8 segundos

});