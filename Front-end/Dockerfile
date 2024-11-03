# Usar a imagem base oficial do Node.js (versão LTS recomendada)
FROM node:18-alpine AS build

# Definir o diretório de trabalho dentro do container
WORKDIR /app

# Copiar o arquivo package.json e o package-lock.json para o contêiner
COPY package*.json ./

# Instalar as dependências do projeto
RUN npm install

# Copiar o código da aplicação para o contêiner
COPY . .

# Construir a aplicação para produção
RUN npm run build

# Usar a imagem base oficial do Node.js (versão LTS recomendada) producao
FROM node:18-alpine AS production

# Define o diretório de trabalho dentro do container
WORKDIR /app

# Copiar os arquivos de build
COPY --from=build /app/dist ./dist 

COPY --from=build /app/public ./public 

COPY --from=build /app/node_modules ./node_modules 

COPY --from=build /app/package.json ./package.json

# Expoe porta 4173
EXPOSE 4173

# Executa o comando quando container for criado
CMD [ "npm", "run", "preview", "--", "--host"]

# # Expor a porta 5173 (ou a porta que você definir)
# EXPOSE 5173

# # Iniciar o Nginx
# CMD ["nginx", "-g", "daemon off;"]
