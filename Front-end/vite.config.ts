import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import path from 'path'

export default defineConfig({
  plugins: [react()],
// should be repository name
  base: "",  
  resolve: {
    alias: {
      '@': path.resolve(__dirname, 'src'), // Set `@` to point to `src`
    },
  },
})

