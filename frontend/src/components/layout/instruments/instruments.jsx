import React from 'react';
import {
  Hero,
  Instruments,
  InstrumentsItem
} from '@code4ro/taskforce-fe-components';

export const InstrumentsWrapper = () => (
  <>
    <div className="border-bottom">
      <Hero title="Instrumente utile" useFallbackIcon />
    </div>

    <Instruments layout="grid">
      <section>
        <InstrumentsItem
          color="green"
          title="Instalează-ţi extensia de Firefox"
          ctaLink="https://addons.mozilla.org/en-US/firefox/addon/covid-19-%C8%99tiri-oficiale/"
          ctaText="Instalează add-on"
        />
        <InstrumentsItem
          color="green"
          title="Instalează-ti extensia de Chrome"
          ctaLink={
            'https://chrome.google.com/webstore/detail/' +
          'covid-19-stiri-oficiale/pdcpkplohipjhdfdchpmgekifmcdbnha'
          }
          ctaText="Instalează add-on"
        />
      </section>
      <section>
        <InstrumentsItem
          color="green"
          title="Ştiri oficiale și informații la zi"
          content=""
          ctaText="Cele mai noi informaţii oficiale"
          ctaLink="https://stirioficiale.ro/informatii"
        />
      </section>
      <section>
        <InstrumentsItem
          color="yellow"
          title="Află ce ai de făcut în orice situație"
          content=""
          ctaText="Ce trebuie să fac"
          ctaLink="https://cemafac.ro"
        />
      </section>
    </Instruments>
  </>
);
