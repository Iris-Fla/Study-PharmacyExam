FROM node:latest

WORKDIR /app

# package.json と package-lock.json (存在する場合) をコピー
COPY ./src/package*.json ./

# 依存関係をインストール
RUN npm install

# その他のソースコードをコピー
COPY ./src/ .

# Nuxt の開発サーバーを起動
CMD ["npm", "run", "dev"]

# # ビルドステージ
# FROM node:latest as build-stage
# WORKDIR /app
# COPY nuxt/package*.json ./
# RUN npm install
# COPY nuxt/ .
# RUN npm run build

# # 実行ステージ
# FROM node:latest-alpine
# WORKDIR /app
# COPY --from=build-stage /app/.nuxt ./.nuxt
# COPY --from=build-stage /app/static ./static
# COPY --from=build-stage /app/package*.json ./
# RUN npm install --only=production
# EXPOSE 3000
# CMD ["npm", "start"]