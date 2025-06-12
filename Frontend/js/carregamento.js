
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

  
  const updateMessage = (newText) => {
    statusMessage.classList.add('fade-out');
    
  
    setTimeout(() => {
      statusMessage.textContent = newText;
      statusMessage.classList.remove('fade-out');
    }, 600); 
  };

  
  const interval = setInterval(() => {
    progress += 1;
    progressBar.style.width = `${progress}%`;

   
    if (progress === 33) {
        updateMessage(messages[0]);
    }
    
    if (progress === 66) {
        updateMessage(messages[1]);
    }

    
    if (progress >= 100) {
      clearInterval(interval);
      
      updateMessage(messages[2]);
      
      
      setTimeout(() => {
        
        
        console.log("Redirecionando para a página de resultados...");
      }, 2000); 
    }
  }, 80); 

});