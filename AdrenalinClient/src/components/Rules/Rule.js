import React from 'react';
import styles from './rules.module.css';
import pdfg from '../../assets/docs/bonuses.pdf';

export default function Rule({ rule }) {
  return (
    <div className={styles.ruleWrapper}>
      <h2>{rule.text}</h2>
      <img src={require('../../assets/img/' + rule.img)} alt="rule"></img>
      <button>
        <a
          download={rule.fileName}
          href={require('../../assets/docs/' + rule.pdf)}
        >
          скачать в pdf
        </a>
      </button>
    </div>
  );
}
