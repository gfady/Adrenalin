import React from 'react';
import styles from './rules.module.css';
import { rules } from '../../data/consts';
import Rule from './Rule';

export default function RuleList() {
  return (
    <div className={styles.rulesWrapper}>
      {rules.map((rule) => (
        <Rule key={rule.id} rule={rule}></Rule>
      ))}
    </div>
  );
}
