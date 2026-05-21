# 🎮 AR Security Game  

📚 **Disciplina:** Optativa - Introdução a Sistemas Virtuais e Aumentados  
👨‍🏫 **Professores:** Lázaro Vinícius de Oliveira Lima | Cristiane Jorge de Lima Bonfim  

---

## 👩‍💻 Autoria:  
- Alice Alves da Gama  
- Luidy Baldez de Melo  

---

# 🎮 Falha Zero — Jogo Educacional em Realidade Aumentada

## 📖 Sobre o Projeto

O **Falha Zero** é um jogo educacional desenvolvido na **Unity** com foco em **conscientização sobre segurança da informação**, utilizando recursos de **Realidade Aumentada (RA)** e elementos interativos gamificados.

O projeto foi criado com o objetivo de tornar o aprendizado sobre vulnerabilidades digitais mais dinâmico, acessível e imersivo, utilizando desafios, missões e objetos interativos em RA para estimular o raciocínio do jogador diante de situações relacionadas à segurança digital.

O jogo utiliza:
- Unity Engine
- AR Foundation
- XR Plugin Management
- Input System
- TextMesh Pro
- Recursos de áudio, animações e interfaces customizadas

---

# 🎯 Objetivo Educacional

O jogo busca ensinar conceitos relacionados à:
- Senhas fracas
- Engenharia social
- Falhas de segurança
- Identificação de ameaças
- Tomada de decisão em ambientes digitais
- Conscientização em cibersegurança

Tudo isso através de mecânicas interativas, missões e exploração em Realidade Aumentada.

---

# 🛠 Tecnologias Utilizadas

## Engine
- Unity

## Recursos XR/RA
- AR Foundation
- ARCore
- XR Plugin Management

## Linguagem
- C#

## Interface
- Unity UI
- TextMesh Pro

## Controle de Versão
- Git
- GitHub

---

# 📂 Estrutura do Projeto

## `Assets/`

Contém todos os recursos principais do jogo.

### `Assets/Scripts`
Scripts responsáveis pela lógica do sistema:
- gerenciamento de jogo
- controle de telas
- ranking
- cronômetro
- fluxo das missões
- interações em RA
- controle de áudio
- cadastro de jogadores

### `Assets/Sprites`
Imagens, telas e elementos visuais da interface.

### `Assets/Audio`
Efeitos sonoros e trilhas do jogo.

### `Assets/XR`
Configurações e recursos relacionados à Realidade Aumentada.

### `Assets/Settings`
Configurações de renderização e perfis do projeto.

---

# 🚀 Principais Funcionalidades

- Sistema de múltiplos jogadores
- Cadastro de participantes
- Ranking de pontuação
- Sistema de insígnias
- Temporizador de jogo
- Transição entre telas
- Objetos clicáveis
- Interação em Realidade Aumentada
- Feedback sonoro
- Sistema de música persistente
- Fluxo narrativo gamificado

---

# 🧠 Scripts Principais

## `GameManager.cs`
Responsável pelo gerenciamento geral do estado do jogo.

## `FluxoJogo.cs`
Controla a sequência lógica das etapas e missões.

## `RankingController.cs`
Gerencia ranking e pontuações dos jogadores.

## `QuizController.cs`
Controla perguntas, respostas e validações.

## `ToqueAR.cs`
Gerencia interações em Realidade Aumentada.

## `ObjetoClicavel.cs`
Responsável pelos objetos interativos clicáveis.

## `ControleMusica.cs`
Gerencia reprodução de músicas e efeitos.

---

# 💻 Requisitos

## Software
- Unity Hub
- Unity Editor
- Git
- Visual Studio ou VS Code

## Versão Recomendada da Unity

Utilizar a mesma versão definida em:

```txt
ProjectSettings/ProjectVersion.txt
```

---

# 📥 Como Baixar o Projeto

## 1. Clonar o repositório

```bash
git clone https://github.com/AliceAlvesG/sistemas-virtuais-ra-projeto.git
```

---

## 2. Abrir no Unity Hub

1. Abra o Unity Hub
2. Clique em **Add Project**
3. Selecione a pasta do projeto
4. Abra utilizando a versão correta da Unity

---

# ▶️ Como Executar

Após abrir o projeto:

1. Aguarde a Unity importar os assets
2. Abra a cena principal
3. Clique em **Play**

---

# ✏️ Como Fazer Alterações

## Atualizar o projeto antes de editar

```bash
git pull origin master
```

---

## Criar uma nova funcionalidade

Faça as alterações normalmente nos:
- scripts
- cenas
- assets
- interfaces

---

## Verificar alterações

```bash
git status
```

---

## Adicionar arquivos ao Git

```bash
git add .
```

---

## Criar commit

```bash
git commit -m "Descrição da alteração"
```

### Exemplo

```bash
git commit -m "Adiciona sistema de ranking"
```

---

## Enviar alterações

```bash
git push origin master
```

---

# 🚫 Arquivos Ignorados

O projeto utiliza `.gitignore` específico para Unity, ignorando:
- `Library/`
- `Temp/`
- `Build/`
- `Logs/`
- arquivos temporários da IDE

Isso evita o envio de arquivos desnecessários ao repositório.

---

# ⚠️ Observações Importantes

## Arquivos `.meta`

Os arquivos `.meta` da Unity devem permanecer versionados no Git, pois são responsáveis por:
- referências internas
- GUIDs dos assets
- conexões entre objetos e cenas

---

## Pastas que NÃO devem ser enviadas manualmente

As seguintes pastas são geradas automaticamente pela Unity:
- `Library`
- `Temp`
- `Obj`
- `Logs`

---

# 📚 Organização do Projeto

O projeto segue uma estrutura modular para facilitar:
- manutenção
- escalabilidade
- colaboração em equipe
- versionamento

---

# 🎓 Finalidade Acadêmica

Este projeto foi desenvolvido com fins:
- acadêmicos
- experimentais
- educacionais

Relacionando:
- gamificação
- realidade aumentada
- segurança da informação
- ensino interativo

---

# 🔗 Repositório

GitHub:
https://github.com/AliceAlvesG/sistemas-virtuais-ra-projeto

---

## 🎨 Protótipo  
🔗 [Acessar protótipo no Figma](https://www.figma.com/design/a5ZW4Li1mfEqs9SyOQAb6R/Projeto---RA---Ciberseguran%C3%A7a?node-id=0-1&p=f&t=HGvbvJbvyZiZ11A0-0)

---

✨ *Projeto desenvolvido com foco em inovação educacional e uso de tecnologias imersivas.*
