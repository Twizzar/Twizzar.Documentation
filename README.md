# TwizzarDocu

## mermaid diagrams

To generate mermaid diagrams install mermaid cli
```bash
npm install -g @mermaid-js/mermaid-cli
```

Then generate the diagrams with
```bash
yarn mermaid
```

The diagrams need to be in the `src/mermaid` directory and need to have the `.mmd` extension.

## Api documentation
To generate the markdown files for the api documentation:
1. install https://ejball.com/XmlDocMarkdown
2. nagiavate to the project bin folder where the dll is located
3. run `xmldocmd .\Twizzar.Api.dll docs --visibility public`
