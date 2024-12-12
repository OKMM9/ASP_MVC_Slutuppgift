/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Views/**/*.cshtml",  // För Razor-sidor
        "./Pages/**/*.cshtml", // För Blazor eller Razor Pages
    ],
  theme: {
    extend: {},
  },
  plugins: [],
}

