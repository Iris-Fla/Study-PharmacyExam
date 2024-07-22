#alpineを使用
FROM node:22-alpine

# # 作業ディレクトリを設定
WORKDIR /app

# # アプリケーションのソースコードをコピー
COPY ./src/ /app/

# # 依存関係をインストール
RUN npm install

EXPOSE 3000
EXPOSE 24678

# # アプリケーションを実行
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