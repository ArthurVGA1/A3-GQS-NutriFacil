# 🥗 NutriFácil

**NutriFácil** é um sistema desktop desenvolvido em C# com Programação Orientada a Objetos (POO), voltado para o planejamento alimentar personalizado. A ferramenta auxilia usuários a obterem recomendações nutricionais conforme seus objetivos (emagrecimento ou hipertrofia), preferências alimentares e possíveis restrições.

---

## ✨ Funcionalidades

- Cálculo automático de:
  - TMB (Taxa de Metabolismo Basal)
  - IMC (Índice de Massa Corporal)
  - Consumo ideal de água
- Seleção de dieta (Mediterrânea, Low Carb, Cetogênica ou Vegetariana)
- Escolha de alimentos por categoria (proteínas, legumes, verduras, carboidratos)
- Registro de alergias e intolerâncias alimentares
- Geração de plano alimentar com base nas preferências e dados inseridos
- Regras nutricionais adaptadas ao sexo, idade, peso e objetivo
- Interface interativa e amigável

---

## 🛠️ Tecnologias Utilizadas

- C# com .NET Framework
- Programação Orientada a Objetos
- VS Code
- HTML
- CSS
- JavaScript
- Visual Studio

---

## 🚀 Como Executar o Projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/nutrifacil.git
   ```

2. Abra o projeto no **Visual Studio**.

3. Compile e execute (`F5` ou botão "Iniciar").

---

## 🧼 Fórmulas Utilizadas

### ✅ TMB – Mifflin-St Jeor

- Masculino: `TMB = 10×peso + 6,25×altura – 5×idade + 5`
- Feminino: `TMB = 10×peso + 6,25×altura – 5×idade – 161`

### ✅ IMC

```plaintext
IMC = peso / (altura/100)²
```

### ✅ Água

```plaintext
Consumo ideal = 35 ml × peso (kg)
```

---

## 📋 Dietas Disponíveis

| Dieta        | Características principais                                 |
| ------------ | ---------------------------------------------------------- |
| Mediterrânea | Azeite, peixes, grãos, frutas e legumes                    |
| Low Carb     | Redução de carboidratos, foco em proteínas e gorduras boas |
| Cetogênica   | Quase zero carboidratos, rica em gorduras                  |
| Vegetariana  | Sem carne, foco em leguminosas, ovos e laticínios          |

---

## 🔐 Restrições Alimentares

O usuário pode indicar alergias ou intolerâncias para:

- Lactose
- Glúten
- Proteína do leite
- Ovo
- Frutos do mar

---

## Testes

### Metas:

1. O usuário deve conseguir configurar seu plano em até 3 minutos
2. Deve ser fácil encontrar e escolher as opções de dieta
3. O preenchimento de dados deve ser guiado e sem erros
4. As recomendações nutricionais devem ser fáceis de entender
5. Deve ser fácil identificar onde informar restrições alimentares

### Participantes

#### Participante 1

- **Nome / Código:** Ana Maria
- **Perfil:** Iniciante
- **Data:** 09/06/2025
- **Moderador:** Arthur Verissimo
- **Dispositivo / Navegador:** Console VS

#### Participante 2

- **Nome / Código:** João Santos
- **Perfil:** Medio
- **Data:** 10/06/2025
- **Moderador:** Arthur Verissimo
- **Dispositivo / Navegador:** Console VS

#### Participante 3

- **Nome / Código:** Carla 
- **Perfil:** Medio
- **Data:** 11/06/2025
- **Moderador:** Hebert Magalhães
- **Dispositivo / Navegador:** Console VS

#### Participante 4

- **Nome / Código:** Pedro
- **Perfil:** Medio
- **Data:** 10/06/2025
- **Moderador:** Hebert Magalhães
- **Dispositivo / Navegador:** Console VS

#### Participante 5

- **Nome / Código:** Luiza 
- **Perfil:** Iniciante
- **Data:** 11/06/2025
- **Moderador:** Hebert Magalhães
- **Dispositivo / Navegador:** Console VS

## Casos de Teste



| ID    | Funcionalidade                     | Pré-Condição                        | Passos                                                                     | Dados de Entrada                                                           | Resultado Esperado                                            | Resultado Obtido                       | Status (✅/❌) | Observações                                                                                   |
| ----- | ---------------------------------- | ----------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | ------------------------------------------------------------- | -------------------------------------- | ------------ | ---------------------------------------------------------------------------------------------- |
| FT-01 | Seleção de Dieta Vegetariana | Usuário já está logado e na tela de seleção de dieta  | 1. Acessar a tela de seleção  2. Escolher "Vegetariana"  3. Preencher os dados pessoais  4. Clicar em "Solicitar Plano Alimentar" | Dieta: `Vegetariana`, Peso: `60`, Altura: `165`, Idade: `35`, Sexo: `Feminino`  | Exibição de plano com vegetais, leguminosas e sem carnes | Plano inclui: Tofu, Lentilha, Espinafre, Quinoa | ✅ | O sistema exibe corretamente itens condizentes com a dieta vegetariana.  |
| FT-02 | Cálculo de TMB para sexo masculino | Dados preenchidos por usuário       | 1. Inserir dados de João 2. Gerar plano alimentar                 | Dieta: `LowCarb`, Peso: `80`, Altura: `180`, Idade: `25`, Sexo: `Masculino` | TMB = 10×80 + 6.25×180 - 5×25 + 5 = 1805 kcal/dia            | Resultado exibido: 1805 kcal/dia                         | ✅           | A fórmula utilizada está correta e bem aplicada no código.                                       |
| FT-03 | Cálculo de IMC e classificação     | Dados pessoais preenchidos          | 1. Inserir dados de Carla 2. Solicitar plano                      | Peso: `60`, Altura: `165`                                                   | IMC = 22.04 → classificado como "Peso normal"                  | Valor exibido corretamente com classificação "Peso normal" | ✅           | A classificação segue as faixas de IMC tradicionais e está clara no código.                    |
| FT-04 | Geração de plano cetogênico        | Dados preenchidos e dieta selecionada | 1. Inserir dados de Pedro 2. Escolher "Cetogênica" 3. Gerar plano | Dieta: `Cetogênica`, Peso: `90`, Altura: `175`, Idade: `40`, Sexo: `Masculino` | Plano com foco em gordura boa e baixo carboidrato | Recomendado: Ovo, Abacate, Queijo, Espinafre, Azeite | ✅           | O sistema exibe alimentos condizentes com a proposta da dieta cetogênica.                      |
| FT-05 | Consumo de água recomendado        | Dados pessoais fornecidos           | 1. Inserir dados de Luiza 2. Solicitar recomendações          | Peso: `68`                                                                 | Volume diário recomendado: 2380 ml                       | Exibido corretamente: 2380 ml/dia                    | ✅           | O cálculo é direto e a fórmula (peso x 35ml) está corretamente aplicada.                        |
| FT-07 | Restrições alimentares aplicadas incorretamente | Usuário já está logado e na tela de seleção de dieta | 1. Acessar a tela de seleção  2. Escolher "LowCarb"  3. Preencher os dados pessoais com restrição a glúten  4. Clicar em "Solicitar Plano Alimentar" | Dieta: `LowCarb`, Peso: `80`, Altura: `180`, Idade: `25`, Sexo: `Masculino`, Restrição: `Glúten` | Alimentos com glúten devem ser evitados | Alimentos com glúten continuam aparecendo | ❌ | O sistema ainda não filtra ingredientes com base nas restrições fornecidas. |
| FT-08 | Preferências alimentares não consideradas | Usuário já está logado e na tela de seleção de dieta | 1. Acessar a tela de seleção  2. Escolher "Mediterrânea"  3. Preencher os dados pessoais com preferências alimentares  4. Clicar em "Solicitar Plano Alimentar" | Dieta: `Mediterrânea`, Peso: `70`, Altura: `170`, Idade: `30`, Sexo: `Feminino`, Preferências: `Peixe, Arroz integral` | Plano deve conter esses alimentos em destaque | Preferências não influenciam o plano | ❌ | Preferências alimentares não estão sendo utilizadas na geração do plano. |

---

## Registro de Bugs

| ID do Bug | Caso de Teste Relacionado | Descrição do Problema                                                                 | Severidade (Alta/Média/Baixa) | Status    | Responsável | Link para issue no GitHub                                                                                  |
| --------- | ------------------------- | ------------------------------------------------------------------------------------- | ----------------------------- | --------- | ----------- | ---------------------------------------------------------------------------------------------------------- |
| BUG-01    | FT-01, FT-04              | Não há validação para dados incomuns (ex: altura negativa, peso zero ou idade muito alta) | Média                         | Em aberto | Arthur Evangelista      | [Issue](https://github.com/ArthurVGA1/A3-GQS-NutriFacil/issues/4)                                                      |
| BUG-02    | FT-03                     | Preferências e restrições alimentares não são usadas para ajustar as recomendações   | Média                         | Em aberto | Arthur Verissimo      | [Issue ](https://github.com/ArthurVGA1/A3-GQS-NutriFacil/issues/3)                                                    |

---



### Tarefas e Métricas - Ana (Iniciante)

**Tabela de Tarefas**
| Nº | Descrição da Tarefa                                           | Tempo Alvo | Tempo Real (s) | Sucesso (S/N) | Erros / Dificuldades                    | Observações do Usuário                |
|----|---------------------------------------------------------------|------------|----------------|---------------|-----------------------------------------|--------------------------------------|
| 1  | Acessar a tela de seleção de dieta                           | 30 s       |       8         |       S        |                                         |                                      |
| 2  | Selecionar "Mediterrânea" e preencher dados pessoais         | 60 s       |       20         |       S        | Leve confusão ao escolher o sexo       | Tem que preencher todos os caracteres corretamente para dar certo |
| 3  | Selecionar preferências alimentares                           | 45 s       |      17         |       N        | Não entendeu que podia marcar múltiplos|                                      |
| 4  | Gerar o plano alimentar e ler as recomendações                | 30 s       |      6          |        S       |                                         | Leu com facilidade                   |
| 5  | Tentar localizar campo de restrições alimentares              | 45 s       |      10          |        N       |                           | Recomendação de tornar campo visível |

**Métricas de Satisfação**
| Critério                      | Nota (1–5) | Comentários                                  |
|------------------------------|------------|-----------------------------------------------|
| Facilidade de navegação      |     3       | Facilidade geral, mas teve dúvidas pontuais   |
| Clareza das instruções       |     4       | Instruções nos botões ajudaram                |
| Velocidade de resposta       |     5       | Respostas rápidas                             |
| Layout e design              |     4       | Visual agradável e moderno                    |
| Confiança ao usar a ferramenta|     4      | Sentiu-se segura em preencher os dados        |

---

### Tarefas e Métricas - João (Medio)

**Tabela de Tarefas**
| Nº | Descrição da Tarefa                                           | Tempo Alvo | Tempo Real (s) | Sucesso (S/N) | Erros / Dificuldades                    | Observações do Usuário                |
|----|---------------------------------------------------------------|------------|----------------|---------------|-----------------------------------------|--------------------------------------|
| 1  | Acessar a tela de seleção de dieta                           | 20 s       |       10         |       S        |                                         |                                      |
| 2  | Selecionar "LowCarb" e preencher dados                       | 45 s       |       20         |       S        |                                         | Fluidez no preenchimento             |
| 3  | Informar restrição alimentar (glúten)                         | 40 s       |       24         |      N         | Não viu resultado coerente              | Esperava alerta ou destaque          |
| 4  | Gerar plano alimentar                                         | 20 s       |       8         |       S        |                                         | Plano com boa visualização           |
| 5  | Localizar botão de ajuda ou informações extras                | 30 s       |                |        N       | Não localizou                           | Sugeriu tutorial ou ícone informativo|

**Métricas de Satisfação**
| Critério                      | Nota (1–5) | Comentários                                  |
|------------------------------|------------|-----------------------------------------------|
| Facilidade de navegação      |     4       | Rápido em localizar menus principais          |
| Clareza das instruções       |     1       | Alguns campos poderiam ter dicas              |
| Velocidade de resposta       |     5       | Resposta excelente                            |
| Layout e design              |     4       | Esteticamente bem resolvido                   |
| Confiança ao usar a ferramenta|    2       | Não teve receio de explorar funções           |

---

### Tarefas e Métricas - Carla (Iniciante)

**Tabela de Tarefas**
| Nº | Descrição da Tarefa                                           | Tempo Alvo | Tempo Real (s) | Sucesso (S/N) | Erros / Dificuldades                    | Observações do Usuário                |
|----|---------------------------------------------------------------|------------|----------------|---------------|-----------------------------------------|--------------------------------------|
| 1  | Acessar a tela de seleção de dieta                           | 35 s       |       5         |        S       |                                         |                                      |
| 2  | Selecionar "Cetogenica" e preencher dados pessoais         | 50 s       |        14        |        S       | Um pouco de dificuldade ao escolher o tipo de dieta     | Interface clara, e intuitíva |
| 3  | Selecionar preferências alimentares                           | 40 s       |      23          |       S        | Sentiu falta de mais opções|                                      |
| 4  | Gerar o plano alimentar e ler as recomendações                | 30 s       |       11         |       S        |                                         | Facilidade no entendimento do resultado                 |
| 5  | Tentar localizar campo de restrições alimentares              | 65 s       |        37        |         S      | Demora ao localizar                          | Recomendação melhorar visibilidade do campo |

**Métricas de Satisfação**
| Critério                      | Nota (1–5) | Comentários                                  |
|------------------------------|------------|-----------------------------------------------|
| Facilidade de navegação      |     3       | Facilidade geral, com dúvidas no formato de escrita      |
| Clareza das instruções       |     5       | Instruções nos botões ajudaram em algumas dívidas        |
| Velocidade de resposta       |     5       | Sem travamentos                                          |
| Layout e design              |     2       | Visual moderno e intuitívo                               |
| Confiança ao usar a ferramenta|     3      | Sem necessidade de instruções adicionais para utilização |

---

### Tarefas e Métricas - Pedro (Medio)

**Tabela de Tarefas**
| Nº | Descrição da Tarefa                                           | Tempo Alvo | Tempo Real (s) | Sucesso (S/N) | Erros / Dificuldades                    | Observações do Usuário                |
|----|---------------------------------------------------------------|------------|----------------|---------------|-----------------------------------------|--------------------------------------|
| 1  | Acessar a tela de seleção de dieta                           | 25 s       |       7         |         S      |                                         |                                      |
| 2  | Selecionar "Vegetariana" e preencher dados                       | 30 s       |       16         |      S         |                                         | Intuitívo            |
| 3  | Informar restrição alimentar (Lactose)                         | 45 s       |        12        |        S       | Poucas opções de alimentos             | Ter opções mais variadas          |
| 4  | Gerar plano alimentar                                         | 27 s       |         8      |         S      |                                         | Plano com boa visualização           |
| 5  | Localizar botão de ajuda ou informações extras                | 40 s       |                |        N       | Não localizou                           | |

**Métricas de Satisfação**
| Critério                      | Nota (1–5) | Comentários                                  |
|------------------------------|------------|-----------------------------------------------|
| Facilidade de navegação      |     5       | Rápido em localizar qual função utilizar          |
| Clareza das instruções       |     5       | Direto ao ponto              |
| Velocidade de resposta       |     4       | Resposta rápida                            |
| Layout e design              |     3       | Facildade de localizar informações                   |
| Confiança ao usar a ferramenta|    5       | Utilizou mais funções           |

---

### Tarefas e Métricas - Luiza (Iniciante)

**Tabela de Tarefas**  
| Nº | Descrição da Tarefa                                           | Tempo Alvo | Tempo Real (s) | Sucesso (S/N) | Erros / Dificuldades                    | Observações do Usuário                |
|----|---------------------------------------------------------------|------------|----------------|---------------|-----------------------------------------|--------------------------------------|
| 1  | Acessar a tela de seleção de dieta                           | 20 s       |       6         |       S        |                                         | Acesso rápido e direto               |
| 2  | Selecionar "Mediterrânea" e preencher dados pessoais         | 40 s       |        11        |      S         |                                         | Navegação fluida e sem dúvidas       |
| 3  | Selecionar preferências alimentares                           | 30 s       |        18        |      S         |                                         | Encontrou opções relevantes          |
| 4  | Informar restrição alimentar (frutos do mar)                  | 35 s       |         16       |       S        | Sistema não deu destaque à restrição    | Esperava que os itens vetados fossem destacados |
| 5  | Gerar o plano alimentar e verificar a adequação               | 25 s       |         12       |       N        | Um item com frutos do mar apareceu      | Plano não respeitou completamente a restrição  |

**Métricas de Satisfação**  
| Critério                      | Nota (1–5) | Comentários                                  |
|------------------------------|------------|-----------------------------------------------|
| Facilidade de navegação      |     5       | Intuitivo e bem estruturado                   |
| Clareza das instruções       |     4       | Apenas o campo de restrição merecia mais destaque |
| Velocidade de resposta       |     5       | Resposta imediata após cada ação              |
| Layout e design              |     5       | Agradável, limpo e coerente                   |
| Confiança ao usar a ferramenta|     3      | Falha na restrição gerou dúvida na confiabilidade |

---

## Feedback Aberto
 **O que você mais gostou?**
- "A navegação foi muito intuitiva e a interface bem limpa. Foi fácil encontrar as opções de dieta e preferências."

 **O que você achou mais difícil?**
- "O sistema não evidenciou minha restrição alimentar de frutos do mar. Um item com camarão apareceu no plano final."

 **Sugestões de melhoria:**
- "Colocar alertas visuais ou destacar alimentos que entram em conflito com restrições alimentares informadas."

---

## Conclusões do Moderador
 **Principais bloqueios encontrados:**
- a. O sistema não impediu nem alertou sobre alimentos conflitantes com a restrição informada
- b. Falta de destaque visual ou aviso para alimentos vetados no plano alimentar final.

 **Pontos fortes observados:**
- a. Interface clara, responsiva e bem estruturada.
- b. Facilidade na navegação e preenchimento das informações pessoais e preferências.

 **Recomendações para próxima iteração:**
- a. Implementar verificação automática e bloqueio de alimentos conflitantes com restrições alimentares.
- b. Adicionar destaque visual ou tooltip sobre itens vetados antes da finalização do plano.

---

## 👥 Equipe

| Nome     | RA                    |
| -------- | ------------------------- |
| Arthur Veríssimo Gonçalves de Abreu  |  4231920281   |
| Arthur Siqueira Evangelista |      4231924746          |
| Bryan Caetano Sena Silva | 4231922321 |
| Hebert Magalhães Soares |      4231925578          |
| Samuel Silva Almeida |      4231922319         |
| Vitoria Gomes Silva |       4231925263        |

---

## 🎯 Objetivos da Equipe

- 💡 Facilitar o acesso à alimentação saudável com personalização
- 🛠️ Praticar os conceitos de POO em um projeto real
- 🎓 Integrar os conhecimentos de lógica, GUI e nutrição

---

## 📂 Estrutura do Projeto

```
NutriFacil/
├── bin/
├── obj/
├── Program.cs
├── Classes/
│   ├── Pessoa.cs
│   ├── CalculadoraSaude.cs
│   └── RecomendacoesAlimentos.cs
├── Program.cs
├── README.md
└── slides/
```

---

## 🦪 Testes de Usabilidade

Foram conduzidos testes com 5 usuários. Resultados:

| Métrica                      | Nota Média (1-5) |
| ---------------------------- | ---------------- |
| Facilidade de navegação      | 4.6              |
| Clareza das instruções       | 4.2              |
| Tempo para completar tarefas | 3.5 min          |
| Design e layout              | 4.4              |

---

## 📈 Resultados

- Sistema funcional com C# e interface simples
- Regras nutricionais validadas
- Testes positivos com usuários
- Facilidade de uso confirmada por feedback qualitativo

---

## 🗂️ Apresentação

A apresentação está disponível na pasta `/slides` em formato `.pptx`.

---

## 📌 Considerações Finais

Este projeto demonstra como aplicar conceitos técnicos em um cenário do mundo real com impacto na saúde. Foi uma excelente oportunidade de aprendizado multidisciplinar.

