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

## 4. Registro de Bugs

| ID do Bug | Caso de Teste Relacionado | Descrição do Problema                                                                 | Severidade (Alta/Média/Baixa) | Status    | Responsável | Link para issue no GitHub                                                                                  |
| --------- | ------------------------- | ------------------------------------------------------------------------------------- | ----------------------------- | --------- | ----------- | ---------------------------------------------------------------------------------------------------------- |
| BUG-01    | FT-01, FT-04              | Não há validação para dados incomuns (ex: altura negativa, peso zero ou idade muito alta) | Média                         | Em aberto | Arthur Evangelista      | [Issue](https://github.com/ArthurVGA1/A3-GQS-NutriFacil/issues/4)                                                      |
| BUG-02    | FT-03                     | Preferências e restrições alimentares não são usadas para ajustar as recomendações   | Média                         | Em aberto | Arthur Verissimo      | [Issue ](https://github.com/ArthurVGA1/A3-GQS-NutriFacil/issues/3)                                                    |

---

